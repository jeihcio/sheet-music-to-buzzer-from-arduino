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

        private int GetDuration(FigureEnum figure)
        {
            switch (figure)
            {
                case FigureEnum.Semibreve:
                    return 1;
                case FigureEnum.Minimum:
                    return 2;
                case FigureEnum.QuarterNote:
                    return 4;
                case FigureEnum.EighthNote:
                    return 8;
                case FigureEnum.SixteenthNote:
                    return 16;
                case FigureEnum.Fusa:
                    return 32;
                case FigureEnum.Semifusa:
                    return 64;
                default:
                    return 0;
            }
        }

        private string GenerateCodeMelody(List<NoteInSheetMusicModel> notes)
        {
            var indentation = "\t";
            var result = string.Empty;
            var listNotes = new List<string>();

            notes.ForEach((note) =>
            {
                var codeNote = indentation;
                var nameNote = string.Empty;

                if (note.Pause)
                {
                    nameNote = "REST";
                    codeNote += nameNote + ", " + GetDuration(note.Duration).ToString();

                }
                else
                {
                    nameNote = Enum.GetName(typeof(NoteEnum), note.Note);
                    nameNote = nameNote
                        .Replace("Note", "NOTE_")
                        .Replace("Do", "C")
                        .Replace("Re", "D")
                        .Replace("Mi", "E")
                        .Replace("Fa", "F")
                        .Replace("Sol", "G")
                        .Replace("La", "A")
                        .Replace("Si", "B");

                    codeNote += nameNote + note.Scale.ToString() + ", " + GetDuration(note.Duration).ToString();
                }

                listNotes.Add(codeNote);
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
