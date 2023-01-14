using ArduinoCodeGenerator.Entities;
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

        private string codeSkeleton()
        {
            var code = @"#define NOTE_C3  131
#define NOTE_CS3 139
#define NOTE_D3  147
#define NOTE_DS3 156
#define NOTE_E3  165
#define NOTE_F3  175
#define NOTE_FS3 185
#define NOTE_G3  196
#define NOTE_GS3 208
#define NOTE_A3  220
#define NOTE_AS3 233
#define NOTE_B3  247
#define NOTE_C4  262
#define NOTE_CS4 277
#define NOTE_D4  294
#define NOTE_DS4 311
#define NOTE_E4  330
#define NOTE_F4  349
#define NOTE_FS4 370
#define NOTE_G4  392
#define NOTE_GS4 415
#define NOTE_A4  440
#define NOTE_AS4 466
#define NOTE_B4  494
#define REST 0";

            return code;
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

            var skeleton = codeSkeleton();
            return fileService.SaveFile(path, skeleton);
        }
    }
}
