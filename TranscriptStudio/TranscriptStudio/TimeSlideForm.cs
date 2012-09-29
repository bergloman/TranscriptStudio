using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranscriptStudio {
    public partial class TimeSlideForm : Form {
        public TimeSlideForm() {
            InitializeComponent();
        }

        public int StartId {
            get {
                return int.Parse(tbStart.Text);
            }
        }
        public int EndId {
            get {
                return int.Parse(tbEnd.Text);
            }
        }
        public bool DoTimeSlide {
            get {
                return cbTimeSlide.Checked;
            }
        }
        public int TimeSlideInSec {
            get {
                return int.Parse(tbTimeSlideSec.Text);
            }
        }
    }
}
