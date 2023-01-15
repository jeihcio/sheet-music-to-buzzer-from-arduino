using ArduinoCodeGenerator.Entities;
using ArduinoCodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCodeGenerator.Service
{
    public class ArduinoService
    {
        private readonly DialogService dialogService;
        private readonly FileService fileService;

        public ArduinoService()
        {
            dialogService = new DialogService();
            fileService = new FileService();
        }

        private string OpenDialog()
        {
            var filter = "Arduino |*.ino";
            return dialogService.SaveDialog(filter);
        }

        public bool GenerateCode(List<NoteInSheetMusicModel> Notes, decimal bpm)
        {
            var path = OpenDialog();
            if (String.IsNullOrEmpty(path)) return false;

            var skeleton = Resources.skeleton;

            var result = fileService.SaveFile(path, skeleton);
            return result;
        }
    }
}
