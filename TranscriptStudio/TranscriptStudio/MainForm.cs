﻿using System;
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

        public MainForm() {
            InitializeComponent();
            FFSpeed = 1.5;
            IsPaused = false;
            this.tbEntryField.Focus();
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

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
            } else if (e.KeyCode == Keys.F9) {
                if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    axWmPlayer.URL = openFileDialog1.FileName;
                    IsPaused = false;
                }
            }
        }
    }
}
