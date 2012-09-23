using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TranscriptStudio {

    using TranscriptStudio.Models;

    public partial class MainForm : Form {

        MainFormModel model;

        public MainForm() {
            InitializeComponent();

            model = new MainFormModel(this.Data) {
                FFSpeed = 1.5,
                IsPaused = false,
                TempXmlFile = @"d:\temp\viktor\a.xml" // TODO
            };
        }

        bool OpenProject() {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return false;

            model.MainXmlFile = openFileDialog1.FileName;
            model.ReadXmlFile();
            model.SaveTempFile();

            this.TranscriptLineBindingSource.DataSource = model.GetLinesDataTable();
            axWmPlayer.URL = model.GetMediaFileName();
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

            model.InitNewProject(saveFileDialog1.FileName, openFileDialog1.FileName);
            model.SaveMainFile();
            model.IsPaused = false;

            axWmPlayer.URL = model.GetMediaFileName();
            this.TranscriptLineBindingSource.DataSource = model.GetLinesDataTable();
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
                var index = model.PushNewTranscriptLine(s, axWmPlayer.Ctlcontrols.currentPosition);
                tbEntryField.Text = "";
                if (index.HasValue) 
                    dataGridView1.FirstDisplayedScrollingRowIndex = index.Value;
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

        void RedrawWarnings() {
            var statuses = model.GetRowStatuses();
            for (int i = 0; i < statuses.Length; i++) {
                if (i >= dataGridView1.RowCount) break;
                if (statuses[i].IsOverlappingWithNext)
                    dataGridView1.Rows[ i].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                else if (statuses[i].IsOverlappingWithPrevious)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                else if (statuses[i].IsTextTooLong)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = dataGridView1.BackColor;
            }
        }

        private void dataBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            model.SaveMainFile();
        }

        private void tsbtnExportXls_Click(object sender, EventArgs e) {
            model.ExportExcel();
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
            model.MoveCurrentLine(id, true);
        }

        private void toolStripButton4_Click(object sender, EventArgs e) {
            // move row down
            var id = GetCurrentRowId();
            model.MoveCurrentLine(id, false);
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
            RedrawWarnings();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            RedrawWarnings();
        }
    }

    
}
