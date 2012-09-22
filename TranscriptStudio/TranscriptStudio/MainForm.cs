using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranscriptStudio {


    public partial class MainForm : Form {

        MainFormModel model;

        public MainForm() {
            InitializeComponent();

            model = new MainFormModel() {
                DataSet = this.Data,
                FFSpeed = 1.5,
                IsPaused = false,
                TempXmlFile = @"d:\temp\viktor\a.xml" // TODO
            };
        }

        bool OpenProject() {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return false;

            model.MainXmlFile = openFileDialog1.FileName;
            model.DataSet.ReadXml(model.MainXmlFile, XmlReadMode.IgnoreSchema);
            model.SaveTempFile();

            this.TranscriptLineBindingSource.DataSource = model.DataSet.TranscriptLine;
            axWmPlayer.URL = model.DataSet.TranscriptUnit.First().FileName;
            model.IsPaused = false;
            EnableToolstripButtons(true);
            return true;
        }

        void EnableToolstripButtons(bool enable) {
            tsbtnExportSrt.Enabled = enable;
            tsbtnExportXls.Enabled = enable;
            tsbtnSave.Enabled = enable;
        }
        bool NewProject() {
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return false;

            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return false;

            model.MainXmlFile = saveFileDialog1.FileName;

            model.DataSet = new data_schema.TranscriptDataSet();
            model.DataSet.TranscriptUnit.AddTranscriptUnitRow(openFileDialog1.FileName, 0, DateTime.Now, DateTime.Now);
            model.DataSet.TranscriptLine.Clear();
            model.DataSet.WriteXml(saveFileDialog1.FileName, XmlWriteMode.WriteSchema);
            model.SaveMainFile();
            model.IsPaused = false;

            axWmPlayer.URL = model.DataSet.TranscriptUnit.First().FileName;
            this.TranscriptLineBindingSource.DataSource = model.DataSet.TranscriptLine;
            EnableToolstripButtons(true);
            return true;
        }

        void NavigateXSec(int sec) {
            var curr_pos = axWmPlayer.Ctlcontrols.currentPosition;
            axWmPlayer.Ctlcontrols.currentPosition = curr_pos + sec;
        }

        void PlayOrPause() {
            if (model.IsPaused)
                axWmPlayer.Ctlcontrols.play();
            else
                axWmPlayer.Ctlcontrols.pause();
            model.IsPaused = !model.IsPaused;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1) {
                NavigateXSec(-10);
            } else if (e.KeyCode == Keys.F2) {
                NavigateXSec(-3);
            } else if (e.KeyCode == Keys.F3) {
                NavigateXSec(3);
            } else if (e.KeyCode == Keys.F4) {
                NavigateXSec(10);
            } else if (e.KeyCode == Keys.F5) {
                PlayOrPause();
            } else if (e.KeyCode == Keys.F6) {
                axWmPlayer.settings.rate = 1 / model.FFSpeed;
            } else if (e.KeyCode == Keys.F7) {
                axWmPlayer.settings.rate = 1;
            } else if (e.KeyCode == Keys.F8) {
                axWmPlayer.settings.rate = model.FFSpeed;
                /*} else if (e.KeyCode == Keys.O && e.Control) {
                    if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                        axWmPlayer.URL = openFileDialog1.FileName;
                        model.IsPaused = false;
                    } */
            } else if (e.KeyCode == Keys.S && e.Control) {
                model.SaveMainFile();
            } else if (e.KeyCode == Keys.Enter) {
                PushNewTranscriptLine();
            }
        }

        private void PushNewTranscriptLine() {
            var s = tbEntryField.Text
                .Replace("\n", " ")
                .Replace("\r", "")
                .Trim();
            if (s.Length != 0) {
                model.PushNewTranscriptLine(s, axWmPlayer.Ctlcontrols.currentPosition);
                tbEntryField.Text = "";
                //dataGridView1.sele
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {

            this.dataGridView1.Enabled = false;
            this.tbEntryField.Enabled = false;
            this.axWmPlayer.Enabled = false;

            var start_form = new StartForm();
            start_form.ShowDialog();
            bool res = false;
            switch (start_form.Result) {
                case StartForm.StartFormResult.New: res = this.NewProject(); break;
                case StartForm.StartFormResult.Open: res = this.OpenProject(); break;
                case StartForm.StartFormResult.Last: break;
            }
            if (res) {
                this.dataGridView1.Enabled = true;
                this.tbEntryField.Enabled = true;
                this.axWmPlayer.Enabled = true;
                this.tbEntryField.Focus();
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void dataBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            model.SaveMainFile();
        }

        private void tsbtnExportXls_Click(object sender, EventArgs e) {
            model.ExportExcel(@"d:\temp\viktor\a.xls");
        }

        private void tsbtnExportSrt_Click(object sender, EventArgs e) {
            model.ExportSrt();
        }

        private void tsbtnSave_Click(object sender, EventArgs e) {
            model.SaveMainFile();
        }

        private void tsbtnNew_Click(object sender, EventArgs e) {
            model.SaveMainFile();
            this.NewProject();
        }

        private void tsbtnOpen_Click(object sender, EventArgs e) {
            model.SaveMainFile();
            this.OpenProject();
        }

        private void tsbtnHelp_Click(object sender, EventArgs e) {
            var form = new MainAboutBox();
            form.ShowDialog();
        }

        private void tsbtnTimeSlide_Click(object sender, EventArgs e) {
            // TODO show dialog for time-sliding
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            // insert new line above current line
            var id = GetCurrentRowId();
            model.SplitLine(id, false);
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            // move row up
            var id = GetCurrentRowId();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) {
            // move row down
            var id = GetCurrentRowId();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            // split current row
            var id = GetCurrentRowId();
            model.SplitLine(id);
        }

        private int GetCurrentRowId() {
            var data_row_view = (DataRowView)TranscriptLineBindingSource.Current;
            var id = (int)data_row_view.Row[0];
            return id;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            
        }
    }

    class MainFormModel {
        public bool IsPaused { get; set; }
        public double FFSpeed { get; set; }
        public double CurrentPosition { get; set; }
        public string TempXmlFile { get; set; }
        public string MainXmlFile { get; set; }
        public data_schema.TranscriptDataSet DataSet { get; set; }

        public void MoveCurrentLine(int id, bool move_up = true) {
            var target = DataSet.TranscriptLine.Where(x => x.Id == id).First();     
            // identify neighbouring line
            //data_schema.TranscriptDataSet.TranscriptLineRow neighbour;
            // TODO
        }

        public void SplitLine(int id, bool copy = true) {
            var target = DataSet.TranscriptLine.Where(x => x.Id == id).First();
            var middle = target.Start + (target.End - target.Start) / 2;
            DataSet.TranscriptLine.AddTranscriptLineRow(target.Text, middle, target.End, target.Speaker);
            target.End = middle;
            if (!copy)
                target.Text = "";
        }

        public void PushNewTranscriptLine(string s, double new_position) {
            if (s.Length != 0) {
                DataSet.TranscriptLine.AddTranscriptLineRow(s, CurrentPosition, new_position, "");
                CurrentPosition = new_position;
                SaveTempFile();
            }
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
