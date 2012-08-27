using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranscriptStudio {
    public partial class MainForm : Form {

        bool IsPaused { get; set; }
        double FFSpeed { get; set; }
        double CurrentPosition { get; set; }
        string TempFile { get; set; }

        public MainForm() {
            InitializeComponent();
            FFSpeed = 1.5;
            IsPaused = false;
            TempFile = @"d:\temp\viktor\a.xml";

            this.Data.TranslationUnit.AddTranslationUnitRow("c:\\temp\\a.avi", 222101, DateTime.Now, DateTime.Now);

            this.Data.TranslationLine.AddTranslationLineRow("Some text 1", 4454, 4458, "");
            this.Data.TranslationLine.AddTranslationLineRow("Some text 2", 5565, 5567, "");
            this.Data.TranslationLine.AddTranslationLineRow("Some text 3", 7787, 7789, "");
        }

        void NavigateXSec(int sec) {
            var curr_pos = axWmPlayer.Ctlcontrols.currentPosition;
            axWmPlayer.Ctlcontrols.currentPosition = curr_pos + sec;
        }

        void PlayOrPause() {

            if (IsPaused)
                axWmPlayer.Ctlcontrols.play();
            else
                axWmPlayer.Ctlcontrols.pause();
            IsPaused = !IsPaused;
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
                axWmPlayer.settings.rate = 1 / FFSpeed;
            } else if (e.KeyCode == Keys.F7) {
                axWmPlayer.settings.rate = 1;
            } else if (e.KeyCode == Keys.F8) {
                axWmPlayer.settings.rate = FFSpeed;
            } else if (e.KeyCode == Keys.O && e.Control) {
                if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    axWmPlayer.URL = openFileDialog1.FileName;
                    IsPaused = false;
                }
            } else if (e.KeyCode == Keys.S && e.Control) {
                SaveTempFile();
            } else if (e.KeyCode == Keys.Enter) {
                PushNewTranslationLine();
            }
        }

        private void SaveTempFile() {
            this.Data.TranslationUnit[0].LastEdit = DateTime.Now;
            this.Data.WriteXml(TempFile, XmlWriteMode.WriteSchema);
        }

        private void PushNewTranslationLine() {
            var s = tbEntryField.Text
                .Replace("\n", "")
                .Replace("\r", "")
                .Trim();
            if (s.Length != 0) {
                var NewPosition = axWmPlayer.Ctlcontrols.currentPosition;
                this.Data.TranslationLine.AddTranslationLineRow(s, CurrentPosition, NewPosition, "");
                CurrentPosition = NewPosition;
                tbEntryField.Text = "";
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            var start_form = new StartForm();
            start_form.ShowDialog();
            switch (start_form.Result) {
                case StartForm.StartFormResult.New: break;
                case StartForm.StartFormResult.Open: break;
                case StartForm.StartFormResult.Last: break;
            }
            //this.tbEntryField.Focus();
            //this.dataGridView1.d
        }

        private void dataBindingSource_CurrentChanged(object sender, EventArgs e) {

        }
    }
}
