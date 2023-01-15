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

        private string GenerateCodeMelody(List<NoteInSheetMusicModel> notes)
        {
            var indentation = "\t";
            var result = string.Empty;
            var listNotes = new List<string>();
            
            var index = 0;
            notes.ForEach((note) =>
            {
                var codeNote = string.Empty;
                if (note.Pause)
                {

                }
                else
                {
                    var nameNote = Enum.GetName(typeof(NoteEnum), note.Note);

                    nameNote = nameNote
                        .Replace("Note", "NOTE_")
                        .Replace("Do", "C")
                        .Replace("Re", "D")
                        .Replace("Mi", "E")
                        .Replace("Fa", "F")
                        .Replace("Sol", "G")
                        .Replace("La", "A")
                        .Replace("Si", "B");

                    codeNote = indentation + nameNote + note.Scale.ToString();
                }

                if (!string.IsNullOrEmpty(codeNote))
                    listNotes.Add(codeNote);

                index++;
            });

            result = String.Join(", \n", listNotes.ToArray());
            return result;
        }

        private string GenerateCode(string skeleton, List<NoteInSheetMusicModel> notes, int bpm)
        {
            var melody = GenerateCodeMelody(notes);

            var result = skeleton
                .Replace("{Number_BPM}", bpm.ToString())
                .Replace("{Melody}", melody);

            return result;
        }

        public bool GenerateCode(List<NoteInSheetMusicModel> notes, decimal bpm)
        {
            var path = OpenDialog();
            if (String.IsNullOrEmpty(path)) return false;

            var skeleton = Resources.skeleton;
            var code = GenerateCode(skeleton, notes, (int)bpm);

            var result = fileService.SaveFile(path, code);
            return result;
        }
    }
}
