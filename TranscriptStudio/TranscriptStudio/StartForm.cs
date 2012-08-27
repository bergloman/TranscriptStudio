using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranscriptStudio {
    public partial class StartForm : Form {

        public enum StartFormResult { New, Open, Last }
        public StartFormResult Result { get; private set; }

        public StartForm() {
            InitializeComponent();
            Result = StartFormResult.New;
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Result = StartFormResult.New;
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            Result = StartFormResult.Open;
            this.Close();
        }

        private void btnLast_Click(object sender, EventArgs e) {
            Result = StartFormResult.Last;
            this.Close();
        }
    }
}
