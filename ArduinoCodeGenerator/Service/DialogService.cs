using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCodeGenerator.Service
{
    class DialogService
    {
        public string SaveDialog(string filter)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = filter
            };
            saveFile.ShowDialog();

            return saveFile.FileName;
        }
    }
}
