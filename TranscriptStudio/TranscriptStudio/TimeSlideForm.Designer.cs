namespace TranscriptStudio {
    partial class TimeSlideForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblStartLine = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.lblEndLine = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimeSlide = new System.Windows.Forms.CheckBox();
            this.tbTimeSlideSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerform = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartLine
            // 
            this.lblStartLine.AutoSize = true;
            this.lblStartLine.Location = new System.Drawing.Point(95, 16);
            this.lblStartLine.Name = "lblStartLine";
            this.lblStartLine.Size = new System.Drawing.Size(48, 13);
            this.lblStartLine.TabIndex = 0;
            this.lblStartLine.Text = "Start line";
            // 
            // tbStart
            // 
            this.tbStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStart.Location = new System.Drawing.Point(149, 13);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(108, 20);
            this.tbStart.TabIndex = 1;
            // 
            // tbEnd
            // 
            this.tbEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnd.Location = new System.Drawing.Point(149, 39);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(108, 20);
            this.tbEnd.TabIndex = 3;
            // 
            // lblEndLine
            // 
            this.lblEndLine.AutoSize = true;
            this.lblEndLine.Location = new System.Drawing.Point(98, 42);
            this.lblEndLine.Name = "lblEndLine";
            this.lblEndLine.Size = new System.Drawing.Size(45, 13);
            this.lblEndLine.TabIndex = 2;
            this.lblEndLine.Text = "End line";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTimeSlide);
            this.groupBox1.Controls.Add(this.tbTimeSlideSec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time slide";
            // 
            // cbTimeSlide
            // 
            this.cbTimeSlide.AutoSize = true;
            this.cbTimeSlide.Location = new System.Drawing.Point(6, 19);
            this.cbTimeSlide.Name = "cbTimeSlide";
            this.cbTimeSlide.Size = new System.Drawing.Size(200, 17);
            this.cbTimeSlide.TabIndex = 7;
            this.cbTimeSlide.Text = "Perform time slide - move lines in time";
            this.cbTimeSlide.UseVisualStyleBackColor = true;
            // 
            // tbTimeSlideSec
            // 
            this.tbTimeSlideSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimeSlideSec.Location = new System.Drawing.Point(137, 42);
            this.tbTimeSlideSec.Name = "tbTimeSlideSec";
            this.tbTimeSlideSec.Size = new System.Drawing.Size(108, 20);
            this.tbTimeSlideSec.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silde by (sec)";
            // 
            // btnPerform
            // 
            this.btnPerform.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPerform.Location = new System.Drawing.Point(115, 227);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(75, 23);
            this.btnPerform.TabIndex = 5;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(196, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TimeSlideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.lblEndLine);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lblStartLine);
            this.Name = "TimeSlideForm";
            this.Text = "TimeSlideForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartLine;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label lblEndLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTimeSlide;
        private System.Windows.Forms.TextBox tbTimeSlideSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Button btnCancel;

    }
}