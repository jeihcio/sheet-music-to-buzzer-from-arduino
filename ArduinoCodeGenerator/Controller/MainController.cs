using ArduinoCodeGenerator.Entities;
using ArduinoCodeGenerator.Entities.Enum;
using ArduinoCodeGenerator.Properties;
using ArduinoCodeGenerator.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCodeGenerator.Controller
{
    class MainController
    {
        private readonly SheetMusicService sheetMusicService;
        private readonly List<NoteInSheetMusic> listNoteInSheetMusic;

        public MainController()
        {
            sheetMusicService = new SheetMusicService();
            listNoteInSheetMusic = new List<NoteInSheetMusic>();
        }

        private NoteInSheetMusic GetNoteInSheetMusic(ComboBox comboNote, NumericUpDown scale)
        {
            var note = (NoteEnum)comboNote.SelectedIndex;
            var result = sheetMusicService.GetNoteInSheetMusic(note, scale);

            return result;
        }

        public void AddFigure(Panel pnlPentagram, ComboBox cmbNote, ComboBox cmbFigure, NumericUpDown numberScale, bool isPause)
        {
            var noteScale = GetNoteInSheetMusic(cmbNote, numberScale);
            var figure = (FigureEnum)cmbFigure.SelectedIndex;
            var image = sheetMusicService.GetImage(figure, noteScale, isPause);

            sheetMusicService.DrawFigure(pnlPentagram, image, noteScale, figure, isPause);
        }

        public void RemoveLastFigure(Panel pnlPentagram)
        {
            sheetMusicService.RemoveLastFigure(pnlPentagram);
        }

        public void SaveImageAs(Panel pnlPentagram)
        {
            sheetMusicService.SaveImageAs(pnlPentagram);
        }
    }
}
