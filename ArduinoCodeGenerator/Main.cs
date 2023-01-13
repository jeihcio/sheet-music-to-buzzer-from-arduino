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
        public Main()
        {
            InitializeComponent();
        }

        private void numberBPM_ValueChanged(object sender, EventArgs e)
        {
            lblBPM.Text = numberBPM.Value.ToString();
        }
    }
}
