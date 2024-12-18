﻿using ArduinoCodeGenerator.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCodeGenerator
{
    public partial class Main : Form
    {
        private readonly MainController controller;

        public Main()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void numberBPM_ValueChanged(object sender, EventArgs e)
        {
            lblBPM.Text = numberBPM.Value.ToString();
        }

        private void btnGenerateCodeArduino_Click(object sender, EventArgs e)
        {
            controller.ExportCodeFromArduino(numberBPM.Value);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            var firstItem = 0;

            cmbNote.SelectedIndex = firstItem;
            cmbFigure.SelectedIndex = firstItem;
            cmbFigurePause.SelectedIndex = firstItem;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            controller.AddFigure(pnlPentagram, pnlSheetMusic, cmbNote, cmbFigure, numberScale, false);            
        }

        private void btnRemoveLastFigure_Click(object sender, EventArgs e)
        {
            controller.RemoveLastFigure(pnlPentagram, pnlSheetMusic);
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SaveImageAs(pnlMain);
        }

        private void btnAddPause_Click(object sender, EventArgs e)
        {
            controller.AddFigure(pnlPentagram, pnlSheetMusic, cmbNote, cmbFigurePause, numberScale, true);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ExportFile(numberBPM.Value);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ImportFile(pnlPentagram, numberBPM);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/jeihcio/sheet-music-to-buzzer-from-arduino");
            Process.Start(sInfo);
        }
    }
}
