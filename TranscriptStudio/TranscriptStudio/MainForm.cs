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
            ToolStripBtnExportExcel.Enabled = enable;
            ToolStripBtnExportSrt.Enabled = enable;
            ToolStripBtnSave.Enabled = enable;
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
            } else if (e.KeyCode == Keys.O && e.Control) {
                if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    axWmPlayer.URL = openFileDialog1.FileName;
                    model.IsPaused = false;
                }
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
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var start_form = new StartForm();
            start_form.ShowDialog();
            bool res = false;
            switch (start_form.Result) {
                case StartForm.StartFormResult.New: res = this.NewProject(); break;
                case StartForm.StartFormResult.Open: res = this.OpenProject(); break;
                case StartForm.StartFormResult.Last: break;
            }
            if (res) {
                this.tbEntryField.Focus();
            } else {
                this.EditPanel.Enabled = false;
                this.WMPlayerpanel.Enabled = false;
            }
        }

        private void dataBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            model.SaveMainFile();
        }

        private void MainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == ToolStripBtnExportExcel) {
                model.ExportExcel(@"d:\temp\viktor\a.xls");
            } else if (e.ClickedItem == ToolStripBtnExportSrt) {
                model.ExportSrt(@"d:\temp\viktor\a.srt");
            } else if (e.ClickedItem == ToolStripBtnNew) {
                model.SaveMainFile();
                this.NewProject();
            } else if (e.ClickedItem == ToolStripBtnOpen) {
                model.SaveMainFile();
                this.OpenProject();
            } else if (e.ClickedItem == ToolStripBtnSave) {
                model.SaveMainFile();
            }
        }
    }

    class MainFormModel {
        public bool IsPaused { get; set; }
        public double FFSpeed { get; set; }
        public double CurrentPosition { get; set; }
        public string TempXmlFile { get; set; }
        public string MainXmlFile { get; set; }
        public data_schema.TranscriptDataSet DataSet { get; set; }

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

        public void ExportExcel(string file_name) {
            var lines = (from x in DataSet.TranscriptLine
                         orderby x.Start
                         select x.Text).ToList();
            File.WriteAllLines(file_name, lines, Encoding.UTF8);
        }

        public void ExportSrt(string file_name) {
            var lines = (from x in DataSet.TranscriptLine
                         orderby x.Start
                         select x.Text).ToList();
            File.WriteAllLines(file_name, lines, Encoding.UTF8);
        }
    }
}
