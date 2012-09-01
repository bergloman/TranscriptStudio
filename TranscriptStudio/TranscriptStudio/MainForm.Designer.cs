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
            this.WMPlayerpanel = new System.Windows.Forms.Panel();
            this.axWmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Speaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranscriptLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolboxPanel = new System.Windows.Forms.Panel();
            this.tbEntryField = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnExportSrt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new TranscriptStudio.data_schema.TranscriptDataSet();
            this.MainStatusStrip.SuspendLayout();
            this.WMPlayerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).BeginInit();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranscriptLineBindingSource)).BeginInit();
            this.MainToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 481);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(783, 22);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(713, 17);
            this.toolStripStatusLabel1.Text = "F1 = -10sec | F2 = -3sec | F3 = +3sec | F4 = +10sec | F5 = play/pause | F6 = slow" +
                " | F7 = normal | F8 = fast | Ctrl+O = open | Ctrl+S = Save";
            // 
            // WMPlayerpanel
            // 
            this.WMPlayerpanel.Controls.Add(this.axWmPlayer);
            this.WMPlayerpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WMPlayerpanel.Location = new System.Drawing.Point(0, 0);
            this.WMPlayerpanel.Name = "WMPlayerpanel";
            this.WMPlayerpanel.Size = new System.Drawing.Size(363, 481);
            this.WMPlayerpanel.TabIndex = 5;
            // 
            // axWmPlayer
            // 
            this.axWmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWmPlayer.Enabled = true;
            this.axWmPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWmPlayer.Name = "axWmPlayer";
            this.axWmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmPlayer.OcxState")));
            this.axWmPlayer.Size = new System.Drawing.Size(363, 481);
            this.axWmPlayer.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(363, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 481);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.dataGridView1);
            this.EditPanel.Controls.Add(this.ToolboxPanel);
            this.EditPanel.Controls.Add(this.tbEntryField);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPanel.Location = new System.Drawing.Point(366, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(417, 481);
            this.EditPanel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.Speaker});
            this.dataGridView1.DataSource = this.TranscriptLineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 324);
            this.dataGridView1.TabIndex = 8;
            // 
            // Speaker
            // 
            this.Speaker.DataPropertyName = "Speaker";
            this.Speaker.HeaderText = "Speaker";
            this.Speaker.Name = "Speaker";
            // 
            // TranscriptLineBindingSource
            // 
            this.TranscriptLineBindingSource.AllowNew = false;
            this.TranscriptLineBindingSource.DataMember = "TranscriptLine";
            this.TranscriptLineBindingSource.DataSource = this.dataBindingSource;
            // 
            // ToolboxPanel
            // 
            this.ToolboxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolboxPanel.Location = new System.Drawing.Point(0, 324);
            this.ToolboxPanel.Name = "ToolboxPanel";
            this.ToolboxPanel.Size = new System.Drawing.Size(417, 47);
            this.ToolboxPanel.TabIndex = 7;
            // 
            // tbEntryField
            // 
            this.tbEntryField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEntryField.Location = new System.Drawing.Point(0, 371);
            this.tbEntryField.Multiline = true;
            this.tbEntryField.Name = "tbEntryField";
            this.tbEntryField.Size = new System.Drawing.Size(417, 110);
            this.tbEntryField.TabIndex = 6;
            this.tbEntryField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnNew,
            this.ToolStripBtnOpen,
            this.ToolStripBtnSave,
            this.ToolStripBtnExportSrt,
            this.ToolStripBtnExportExcel});
            this.MainToolStrip.Location = new System.Drawing.Point(1, 1);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(127, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            this.MainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainToolStrip_ItemClicked);
            // 
            // ToolStripBtnNew
            // 
            this.ToolStripBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnNew.Image")));
            this.ToolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnNew.Name = "ToolStripBtnNew";
            this.ToolStripBtnNew.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnNew.Text = "toolStripButton1";
            this.ToolStripBtnNew.ToolTipText = "Create new project";
            // 
            // ToolStripBtnOpen
            // 
            this.ToolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnOpen.Image")));
            this.ToolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnOpen.Name = "ToolStripBtnOpen";
            this.ToolStripBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnOpen.Text = "toolStripButton2";
            this.ToolStripBtnOpen.ToolTipText = "Open existing project";
            // 
            // ToolStripBtnSave
            // 
            this.ToolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnSave.Enabled = false;
            this.ToolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnSave.Image")));
            this.ToolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSave.Name = "ToolStripBtnSave";
            this.ToolStripBtnSave.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnSave.Text = "toolStripButton3";
            // 
            // ToolStripBtnExportSrt
            // 
            this.ToolStripBtnExportSrt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnExportSrt.Enabled = false;
            this.ToolStripBtnExportSrt.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnExportSrt.Image")));
            this.ToolStripBtnExportSrt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnExportSrt.Name = "ToolStripBtnExportSrt";
            this.ToolStripBtnExportSrt.Size = new System.Drawing.Size(23, 23);
            this.ToolStripBtnExportSrt.Text = "ToolStripBtnExportSrt";
            this.ToolStripBtnExportSrt.ToolTipText = "ToolStripBtnExportSrt";
            // 
            // ToolStripBtnExportExcel
            // 
            this.ToolStripBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnExportExcel.Enabled = false;
            this.ToolStripBtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnExportExcel.Image")));
            this.ToolStripBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnExportExcel.Name = "ToolStripBtnExportExcel";
            this.ToolStripBtnExportExcel.Size = new System.Drawing.Size(23, 23);
            this.ToolStripBtnExportExcel.Text = "ToolStripBtnExportExcel";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.MainToolStrip);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(417, 27);
            this.toolStripContainer1.Location = new System.Drawing.Point(366, 324);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(417, 27);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 400;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 503);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.WMPlayerpanel);
            this.Controls.Add(this.MainStatusStrip);
            this.Name = "MainForm";
            this.Text = "Transcript Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.WMPlayerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranscriptLineBindingSource)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel WMPlayerpanel;
        private AxWMPLib.AxWindowsMediaPlayer axWmPlayer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.TextBox tbEntryField;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ToolboxPanel;
        private data_schema.TranscriptDataSet Data;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource TranscriptLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speaker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripBtnNew;
        private System.Windows.Forms.ToolStripButton ToolStripBtnOpen;
        private System.Windows.Forms.ToolStripButton ToolStripBtnSave;
        private System.Windows.Forms.ToolStripButton ToolStripBtnExportSrt;
        private System.Windows.Forms.ToolStripButton ToolStripBtnExportExcel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

