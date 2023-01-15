using ArduinoCodeGenerator.Entities;
using ArduinoCodeGenerator.Entities.Enum;
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

        private string GenerateCode(string skeleton, List<NoteInSheetMusicModel> Notes, int bpm)
        {
            var result = skeleton
                .Replace("{Number_BPM}", bpm.ToString())
                .Replace("{Melody}", "");

            return result;
        }

        public bool GenerateCode(List<NoteInSheetMusicModel> Notes, decimal bpm)
        {
            var path = OpenDialog();
            if (String.IsNullOrEmpty(path)) return false;

            var skeleton = Resources.skeleton;
            var code = GenerateCode(skeleton, Notes, (int)bpm);

            var result = fileService.SaveFile(path, code);
            return result;
        }
    }
}
