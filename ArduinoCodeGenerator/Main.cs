using ArduinoCodeGenerator.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            var noteScale = controller.GetNoteInSheetMusic(cmbNote, numberScale);
            var figure = controller.GetImage(cmbFigure, noteScale);
            controller.DrawFigure(pnlPentagram, figure, noteScale);
        }
    }
}
