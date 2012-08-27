﻿namespace TranscriptStudio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.translationLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new TranscriptStudio.data_schema.TranslationDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbEntryField = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).BeginInit();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 561);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1193, 22);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.axWmPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 561);
            this.panel1.TabIndex = 5;
            // 
            // axWmPlayer
            // 
            this.axWmPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axWmPlayer.Enabled = true;
            this.axWmPlayer.Location = new System.Drawing.Point(4, 3);
            this.axWmPlayer.Name = "axWmPlayer";
            this.axWmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmPlayer.OcxState")));
            this.axWmPlayer.Size = new System.Drawing.Size(404, 555);
            this.axWmPlayer.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(412, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 561);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.dataGridView1);
            this.EditPanel.Controls.Add(this.panel2);
            this.EditPanel.Controls.Add(this.tbEntryField);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPanel.Location = new System.Drawing.Point(415, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(778, 561);
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
            this.dataGridView1.DataSource = this.translationLineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 374);
            this.dataGridView1.TabIndex = 8;
            // 
            // translationLineBindingSource
            // 
            this.translationLineBindingSource.AllowNew = false;
            this.translationLineBindingSource.DataMember = "TranslationLine";
            this.translationLineBindingSource.DataSource = this.dataBindingSource;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = this.Data;
            this.dataBindingSource.Position = 0;
            this.dataBindingSource.CurrentChanged += new System.EventHandler(this.dataBindingSource_CurrentChanged);
            // 
            // Data
            // 
            this.Data.DataSetName = "TranslationDataSet";
            this.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 57);
            this.panel2.TabIndex = 7;
            // 
            // tbEntryField
            // 
            this.tbEntryField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEntryField.Location = new System.Drawing.Point(0, 431);
            this.tbEntryField.Multiline = true;
            this.tbEntryField.Name = "tbEntryField";
            this.tbEntryField.Size = new System.Drawing.Size(778, 130);
            this.tbEntryField.TabIndex = 6;
            this.tbEntryField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // Speaker
            // 
            this.Speaker.DataPropertyName = "Speaker";
            this.Speaker.HeaderText = "Speaker";
            this.Speaker.Name = "Speaker";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 583);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainStatusStrip);
            this.Name = "MainForm";
            this.Text = "Translation Studio";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWmPlayer)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWmPlayer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.TextBox tbEntryField;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private data_schema.TranslationDataSet Data;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource translationLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speaker;
    }
}

