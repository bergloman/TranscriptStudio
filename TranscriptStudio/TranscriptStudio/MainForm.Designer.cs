namespace TranscriptStudio
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.axWmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TranscriptLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new TranscriptStudio.data_schema.TranscriptDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbEntryField = new System.Windows.Forms.TextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportXls = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportSrt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportHtml = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTimeSlide = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSplit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMoveCurrentRowUp = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMoveCurrentRowDown = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.tsbtnJoin = new System.Windows.Forms.ToolStripButton();
            this.tsbtnManualTimes = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranscriptLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 347);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(577, 22);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(747, 15);
            this.toolStripStatusLabel1.Text = "F1 = -10sec | F2 = -3sec | F3 = +3sec | F4 = +10sec | F5 = play/pause | F6 = slow" +
    " | F7 = normal | F8 = fast | F9 = play current line | Ctrl+S = Save";
            // 
            // axWmPlayer
            // 
            this.axWmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWmPlayer.Enabled = true;
            this.axWmPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWmPlayer.Name = "axWmPlayer";
            this.axWmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmPlayer.OcxState")));
            this.axWmPlayer.Size = new System.Drawing.Size(257, 322);
            this.axWmPlayer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.StartText,
            this.EndText,
            this.Speaker,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.TranscriptLineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 265);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // TranscriptLineBindingSource
            // 
            this.TranscriptLineBindingSource.AllowNew = false;
            this.TranscriptLineBindingSource.DataMember = "TranscriptLine";
            this.TranscriptLineBindingSource.DataSource = this.dataBindingSource;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = this.Data;
            this.dataBindingSource.Position = 0;
            this.dataBindingSource.CurrentChanged += new System.EventHandler(this.dataBindingSource_CurrentChanged);
            // 
            // Data
            // 
            this.Data.DataSetName = "TranscriptDataSet";
            this.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open existing file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save project file";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnOpen,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnExportXls,
            this.tsbtnExportSrt,
            this.tsbtnExportHtml,
            this.toolStripSeparator3,
            this.tsbtnTimeSlide,
            this.toolStripSeparator2,
            this.tsbtnHelp,
            this.tsbtnSplit,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.tsbtnMoveCurrentRowUp,
            this.tsbtnMoveCurrentRowDown,
            this.tsbtnDeleteRow,
            this.tsbtnJoin,
            this.toolStripSeparator5,
            this.tsbtnManualTimes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 322);
            this.panel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axWmPlayer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.tbEntryField);
            this.splitContainer1.Size = new System.Drawing.Size(577, 322);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 9;
            // 
            // tbEntryField
            // 
            this.tbEntryField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEntryField.Location = new System.Drawing.Point(0, 265);
            this.tbEntryField.Multiline = true;
            this.tbEntryField.Name = "tbEntryField";
            this.tbEntryField.Size = new System.Drawing.Size(316, 57);
            this.tbEntryField.TabIndex = 6;
            this.tbEntryField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Width = 54;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.Width = 51;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 53;
            // 
            // StartText
            // 
            this.StartText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartText.DataPropertyName = "StartText";
            this.StartText.HeaderText = "StartText";
            this.StartText.Name = "StartText";
            this.StartText.ReadOnly = true;
            this.StartText.Width = 75;
            // 
            // EndText
            // 
            this.EndText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndText.DataPropertyName = "EndText";
            this.EndText.HeaderText = "EndText";
            this.EndText.Name = "EndText";
            this.EndText.ReadOnly = true;
            this.EndText.Width = 72;
            // 
            // Speaker
            // 
            this.Speaker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Speaker.DataPropertyName = "Speaker";
            this.Speaker.HeaderText = "Speaker";
            this.Speaker.Name = "Speaker";
            this.Speaker.Width = 72;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNew.Image = global::TranscriptStudio.Properties.Resources.script;
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNew.Text = "New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = global::TranscriptStudio.Properties.Resources.folder;
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbtnOpen.Text = "Open";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = global::TranscriptStudio.Properties.Resources.disk;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnExportXls
            // 
            this.tsbtnExportXls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExportXls.Image = global::TranscriptStudio.Properties.Resources.page_excel;
            this.tsbtnExportXls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportXls.Name = "tsbtnExportXls";
            this.tsbtnExportXls.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExportXls.Text = "Export to Excel";
            this.tsbtnExportXls.Click += new System.EventHandler(this.tsbtnExportXls_Click);
            // 
            // tsbtnExportSrt
            // 
            this.tsbtnExportSrt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExportSrt.Image = global::TranscriptStudio.Properties.Resources.page;
            this.tsbtnExportSrt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportSrt.Name = "tsbtnExportSrt";
            this.tsbtnExportSrt.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExportSrt.Text = "Export to .srt";
            this.tsbtnExportSrt.Click += new System.EventHandler(this.tsbtnExportSrt_Click);
            // 
            // tsbtnExportHtml
            // 
            this.tsbtnExportHtml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExportHtml.Image = global::TranscriptStudio.Properties.Resources.html;
            this.tsbtnExportHtml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportHtml.Name = "tsbtnExportHtml";
            this.tsbtnExportHtml.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExportHtml.Text = "Export HTML";
            this.tsbtnExportHtml.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tsbtnTimeSlide
            // 
            this.tsbtnTimeSlide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTimeSlide.Image = global::TranscriptStudio.Properties.Resources.clock;
            this.tsbtnTimeSlide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimeSlide.Name = "tsbtnTimeSlide";
            this.tsbtnTimeSlide.Size = new System.Drawing.Size(23, 22);
            this.tsbtnTimeSlide.Text = "Time-slide selection";
            this.tsbtnTimeSlide.Click += new System.EventHandler(this.tsbtnTimeSlide_Click);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = global::TranscriptStudio.Properties.Resources.information;
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHelp.Text = "Product information";
            this.tsbtnHelp.Click += new System.EventHandler(this.tsbtnHelp_Click);
            // 
            // tsbtnSplit
            // 
            this.tsbtnSplit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSplit.Image = global::TranscriptStudio.Properties.Resources.arrow_divide;
            this.tsbtnSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSplit.Name = "tsbtnSplit";
            this.tsbtnSplit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSplit.Text = "Split current text";
            this.tsbtnSplit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TranscriptStudio.Properties.Resources.asterisk_yellow;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Insert new text above current";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbtnMoveCurrentRowUp
            // 
            this.tsbtnMoveCurrentRowUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveCurrentRowUp.Image = global::TranscriptStudio.Properties.Resources.arrow_up;
            this.tsbtnMoveCurrentRowUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMoveCurrentRowUp.Name = "tsbtnMoveCurrentRowUp";
            this.tsbtnMoveCurrentRowUp.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveCurrentRowUp.Text = "Move current row up";
            this.tsbtnMoveCurrentRowUp.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbtnMoveCurrentRowDown
            // 
            this.tsbtnMoveCurrentRowDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveCurrentRowDown.Image = global::TranscriptStudio.Properties.Resources.arrow_down;
            this.tsbtnMoveCurrentRowDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMoveCurrentRowDown.Name = "tsbtnMoveCurrentRowDown";
            this.tsbtnMoveCurrentRowDown.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveCurrentRowDown.Text = "Move current row down";
            this.tsbtnMoveCurrentRowDown.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbtnDeleteRow
            // 
            this.tsbtnDeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDeleteRow.Image = global::TranscriptStudio.Properties.Resources.cross;
            this.tsbtnDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeleteRow.Name = "tsbtnDeleteRow";
            this.tsbtnDeleteRow.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDeleteRow.Text = "Delete current row";
            this.tsbtnDeleteRow.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsbtnJoin
            // 
            this.tsbtnJoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnJoin.Image = global::TranscriptStudio.Properties.Resources.arrow_join;
            this.tsbtnJoin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnJoin.Name = "tsbtnJoin";
            this.tsbtnJoin.Size = new System.Drawing.Size(23, 22);
            this.tsbtnJoin.Text = "Join current and next row";
            this.tsbtnJoin.Click += new System.EventHandler(this.tsbtnJoin_Click);
            // 
            // tsbtnManualTimes
            // 
            this.tsbtnManualTimes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnManualTimes.Image = global::TranscriptStudio.Properties.Resources.flag_blue;
            this.tsbtnManualTimes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnManualTimes.Name = "tsbtnManualTimes";
            this.tsbtnManualTimes.Size = new System.Drawing.Size(23, 22);
            this.tsbtnManualTimes.Text = "Set time points manually";
            this.tsbtnManualTimes.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainStatusStrip);
            this.Name = "MainForm";
            this.Text = "Transcript Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranscriptLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private AxWMPLib.AxWindowsMediaPlayer axWmPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private data_schema.TranscriptDataSet Data;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource TranscriptLineBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnExportXls;
        private System.Windows.Forms.ToolStripButton tsbtnExportSrt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbEntryField;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnTimeSlide;
        private System.Windows.Forms.ToolStripButton tsbtnSplit;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnMoveCurrentRowUp;
        private System.Windows.Forms.ToolStripButton tsbtnMoveCurrentRowDown;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteRow;
        private System.Windows.Forms.ToolStripButton tsbtnExportHtml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnManualTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartText;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbtnJoin;
        
    }
}

