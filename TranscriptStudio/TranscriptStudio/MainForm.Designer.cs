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
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranscriptLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new TranscriptStudio.data_schema.TranscriptDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExportXls = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportSrt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnTimeSlide = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbEntryField = new System.Windows.Forms.TextBox();
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(627, 15);
            this.toolStripStatusLabel1.Text = "F1 = -10sec | F2 = -3sec | F3 = +3sec | F4 = +10sec | F5 = play/pause | F6 = slow" +
                " | F7 = normal | F8 = fast | Ctrl+S = Save";
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
            this.Speaker,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.TranscriptLineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 265);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
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
            this.toolStripSeparator3,
            this.tsbtnTimeSlide,
            this.toolStripSeparator2,
            this.tsbtnHelp,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNew.Image = global::TranscriptStudio.Properties.Resources.script;
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNew.Text = "toolStripButton1";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = global::TranscriptStudio.Properties.Resources.folder;
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbtnOpen.Text = "toolStripButton2";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = global::TranscriptStudio.Properties.Resources.disk;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "toolStripButton3";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnExportXls
            // 
            this.tsbtnExportXls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExportXls.Image = global::TranscriptStudio.Properties.Resources.page_excel;
            this.tsbtnExportXls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportXls.Name = "tsbtnExportXls";
            this.tsbtnExportXls.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExportXls.Text = "toolStripButton4";
            this.tsbtnExportXls.Click += new System.EventHandler(this.tsbtnExportXls_Click);
            // 
            // tsbtnExportSrt
            // 
            this.tsbtnExportSrt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExportSrt.Image = global::TranscriptStudio.Properties.Resources.page;
            this.tsbtnExportSrt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportSrt.Name = "tsbtnExportSrt";
            this.tsbtnExportSrt.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExportSrt.Text = "toolStripButton5";
            this.tsbtnExportSrt.Click += new System.EventHandler(this.tsbtnExportSrt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnTimeSlide
            // 
            this.tsbtnTimeSlide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTimeSlide.Image = global::TranscriptStudio.Properties.Resources.clock;
            this.tsbtnTimeSlide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimeSlide.Name = "tsbtnTimeSlide";
            this.tsbtnTimeSlide.Size = new System.Drawing.Size(23, 22);
            this.tsbtnTimeSlide.Text = "toolStripButton1";
            this.tsbtnTimeSlide.Click += new System.EventHandler(this.tsbtnTimeSlide_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = global::TranscriptStudio.Properties.Resources.information;
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHelp.Text = "toolStripButton1";
            this.tsbtnHelp.Click += new System.EventHandler(this.tsbtnHelp_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TranscriptStudio.Properties.Resources.arrow_divide;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TranscriptStudio.Properties.Resources.asterisk_yellow;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TranscriptStudio.Properties.Resources.arrow_up;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::TranscriptStudio.Properties.Resources.arrow_down;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        
    }
}

