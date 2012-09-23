using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace TranscriptStudio.Models {


    class RowStatus {
        public RowStatus() {
            IsOverlappingWithNext = false;
            IsOverlappingWithPrevious = false;
            IsTextTooLong = false;
        }
        public bool IsOverlappingWithNext { get; set; }
        public bool IsOverlappingWithPrevious { get; set; }
        public bool IsTextTooLong { get; set; }
    }

    class MainFormModel {

        public MainFormModel(data_schema.TranscriptDataSet data) {
            DataSet = data;
        }

        public bool IsPaused { get; set; }
        public double FFSpeed { get; set; }
        public double CurrentPosition { get; set; }
        public string TempXmlFile { get; set; }
        public string MainXmlFile { get; set; }
        data_schema.TranscriptDataSet DataSet { get; set; }

        public RowStatus[] GetRowStatuses() {
            var res = new List<RowStatus>();
            var data = (from x in DataSet.TranscriptLine orderby x.Start, x.End, x.Text select x).ToArray();
            data_schema.TranscriptDataSet.TranscriptLineRow last = null;
            data_schema.TranscriptDataSet.TranscriptLineRow next = null;
            for (int i = 0; i < data.Length; i++) {
                var current = data[i];
                if (i < data.Length - 1)
                    next = data[i + 1];
                else 
                    next = null;

                var rec = new RowStatus();
                if (last != null && last.End > current.Start) {
                    rec.IsOverlappingWithPrevious = true;
                }
                if (next!= null && next.Start < current.End) {
                    rec.IsOverlappingWithNext = true;
                }
                if (current.Text != null && current.Text.Length > 40)
                    rec.IsTextTooLong = true;

                res.Add(rec);
                last = current;
            }
            return res.ToArray();
        }

        public void InitNewProject(string main_xml_file, string media_file) {
            MainXmlFile = main_xml_file;
            DataSet = new data_schema.TranscriptDataSet();
            DataSet.TranscriptUnit.AddTranscriptUnitRow(media_file, 0, DateTime.Now, DateTime.Now);
            DataSet.TranscriptLine.Clear();
            DataSet.WriteXml(main_xml_file, XmlWriteMode.IgnoreSchema);
        }

        public string GetMediaFileName() {
            return DataSet.TranscriptUnit.First().FileName;
        }

        public void ReadXmlFile() {
            DataSet.ReadXml(MainXmlFile, XmlReadMode.IgnoreSchema);
        }

        public data_schema.TranscriptDataSet.TranscriptLineDataTable GetLinesDataTable() {
            return this.DataSet.TranscriptLine;
        }

        void RecalcIds() {
            var data = (from x in DataSet.TranscriptLine orderby x.Start, x.End, x.Text select x).ToList();
            var i = -10000;
            foreach (var x in data) {
                x.Id = i--;
            }
            i = 0;
            foreach (var x in data) {
                x.Id = i++;
            }
        }

        public void MoveCurrentLine(int id, bool move_up = true) {
            if (id == 0 && move_up)
                return; // nothing to do, we're already at the top
            if (!move_up && id == DataSet.TranscriptLine.Count - 1)
                return; // nothing to do, we're already at the bottom

            var target = DataSet.TranscriptLine.Where(x => x.Id == id).First();
            var neighbour_id = id + (move_up ? -1 : 1);
            var neighbour = DataSet.TranscriptLine.Where(x => x.Id == neighbour_id).First();

            // swap the data
            var speaker = target.Speaker;
            var text = target.Text;
            target.Speaker = neighbour.Speaker;
            target.Text = neighbour.Text;
            neighbour.Speaker=speaker;
            neighbour.Text=text;
        }

        public int AddLine(string Text, double Start, double End, string Speaker) {
            DataSet.TranscriptLine.AddTranscriptLineRow(-1, Text, Start, End, Speaker);
            RecalcIds();
            return DataSet.TranscriptLine
                .Where(x => x.Text == Text && x.Start == Start && x.End == End)
                .Select(x => x.Id)
                .First();
        }

        public void SplitLine(int id, bool copy = true) {
            var target = DataSet.TranscriptLine.Where(x => x.Id == id).First();
            var middle = target.Start + (target.End - target.Start) / 2;
            AddLine(target.Text, middle, target.End, target.Speaker);
            target.End = middle;
            if (!copy)
                target.Text = "";
            RecalcIds();
        }

        public int? PushNewTranscriptLine(string s, double new_position) {
            if (s.Length != 0) {
                var res = AddLine(s, CurrentPosition, new_position, "");
                CurrentPosition = new_position;
                SaveTempFile();
                return res;
            } 
            return null;
        }

        public void SaveTempFile() {
            if (DataSet.TranscriptUnit.Count == 0) {
                DataSet.TranscriptUnit.AddTranscriptUnitRow(MainXmlFile, 0, DateTime.Now, DateTime.Now);
            }
            DataSet.TranscriptUnit[0].LastEdit = DateTime.Now;
            DataSet.WriteXml(TempXmlFile, XmlWriteMode.IgnoreSchema);
        }

        public void SaveMainFile() {
            DataSet.TranscriptUnit[0].LastEdit = DateTime.Now;
            DataSet.WriteXml(MainXmlFile, XmlWriteMode.IgnoreSchema);
        }

        public void ExportExcel(string file_name = null) {
            if (file_name == null)
                file_name = Path.ChangeExtension(DataSet.TranscriptUnit.First().FileName, "csv");
            var lines = (from x in DataSet.TranscriptLine
                         orderby x.Start
                         select x.Text).ToList();
            File.WriteAllLines(file_name, lines, Encoding.UTF8);
        }

        string ToSrtTime(double val) {
            int h = (int)val / (60 * 60);
            int m = (int)(val / 60 - h * 60);
            int s = (int)(val - h * 60 * 60 - m * 60);
            int ms = (int)Math.Floor(1000 * (val - (int)val));
            return string.Format("{0:d2}:{1:d2}:{2:d2},{3:d3}", h, m, s, ms);
        }

        public void ExportSrt(string file_name = null) {
            if (file_name == null)
                file_name = Path.ChangeExtension(DataSet.TranscriptUnit.First().FileName, "srt");
            var lines = (from x in DataSet.TranscriptLine
                         orderby x.Start
                         select
                            x.Id + Environment.NewLine +
                            ToSrtTime(x.Start) + " --> " + ToSrtTime(x.End) + Environment.NewLine +
                            x.Text + Environment.NewLine).ToList();
            File.WriteAllLines(file_name, lines, Encoding.UTF8);
        }
    }
}

