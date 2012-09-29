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
            WarningLength = 60;
        }

        public bool IsPaused { get; set; }
        public double FFSpeed { get; set; }
        public double CurrentPosition { get; set; }
        public string TempXmlFile { get; set; }
        public string MainXmlFile { get; set; }
        public int WarningLength { get; set; }
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
                if (next != null && next.Start < current.End) {
                    rec.IsOverlappingWithNext = true;
                }
                if (current.Text != null && current.Text.Length > WarningLength)
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

        public void RecalcTimeStrings(int current_id = -1) {
            if (current_id >= 0) {
                var line = DataSet.TranscriptLine.Where(x => x.Id == current_id).First();
                line.StartText = line.Start.FromDoubleToTimeStr();
                line.EndText = line.End.FromDoubleToTimeStr();
            } else {
                var data = (from x in DataSet.TranscriptLine orderby x.Start, x.End, x.Text select x).ToList();
                foreach (var x in data) {
                    x.StartText = x.Start.FromDoubleToTimeStr();
                    x.EndText = x.End.FromDoubleToTimeStr();
                }
            }
        }
        public void RecalcIds() {
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
            neighbour.Speaker = speaker;
            neighbour.Text = text;
        }

        public int AddLine(string Text, double Start, double End, string Speaker) {
            DataSet.TranscriptLine.AddTranscriptLineRow(-1, Text, Start, End, Speaker, Start.FromDoubleToTimeStr(), End.FromDoubleToTimeStr());
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

        public void TimeSlide(int start_id, int end_id, int slide_in_sec) {
            var data = (from x in DataSet.TranscriptLine
                        where x.Id >= start_id && x.Id <= end_id
                        orderby x.Start, x.End, x.Text
                        select x).ToList();
            foreach (var x in data) {
                x.Start += slide_in_sec;
                x.End += slide_in_sec;
            }
            this.RecalcIds();
            this.RecalcTimeStrings();
        }

        public void DeleteRow(int id) {
            var row = DataSet.TranscriptLine.Where(x => x.Id == id).First();
            DataSet.TranscriptLine.RemoveTranscriptLineRow(row);
            this.RecalcIds();
        }

        public double GetRowStart(int id) {
            var row = DataSet.TranscriptLine.Where(x => x.Id == id).First();
            return row.Start;
        }

        ///////////////////////////////////////////////////////////////////////////////


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

        public void ExportHtml(string file_name = null) {
            if (file_name == null)
                file_name = Path.ChangeExtension(DataSet.TranscriptUnit.First().FileName, "html");
            var lines = (from x in DataSet.TranscriptLine
                         orderby x.Start, x.End
                         select x).ToList();

            var sb = new StringBuilder();
            sb.Append(@"<html>
    <head>
    <style type=""text/css"">
        body { font-family: Calibri, Arial; }        
        td, th { padding: 10px; vertical-align: top; }
        table { border: 1px solid #cccccc; }
    </style>
    </head>
    <body>
        <table>");

            var last_speaker = string.Empty;
            var first = true;
            //var batch_cnt = 0;
            foreach (var line in lines) {
                if (first || (!string.IsNullOrEmpty(line.Speaker) && line.Speaker != last_speaker)) {
                    if (first) {
                        first = false;
                    } else {
                        sb.Append("</td></tr>");
                    }
                    sb.AppendFormat("<tr><th>{0}</th><td>{1}</td><td>", line.Speaker, line.StartText);
                    last_speaker = line.Speaker;
                    //batch_cnt = 0;
                }

                //if (batch_cnt > 0 && batch_cnt % 10 == 0) {
                //    sb.Append("</td></tr>");
                //    sb.AppendFormat("<tr><td>-</td><td>{0}</td><td>", line.StartText);
                //}
                sb.Append(line.Text);
                sb.Append(" ");
                //batch_cnt++;
            }

            sb.Append("</td></tr></table></body></html>");

            File.WriteAllText(file_name, sb.ToString(), Encoding.UTF8);
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

