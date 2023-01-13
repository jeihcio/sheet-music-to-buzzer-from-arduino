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

        public MainController()
        {
            sheetMusicService = new SheetMusicService();
        }

        public Image GetImage(ComboBox comboFigure, NoteInSheetMusic note)
        {
            var figure = (FigureEnum)comboFigure.SelectedIndex;
            var result = sheetMusicService.GetImage(figure, note);

            return result;
        }

        public NoteInSheetMusic GetNoteInSheetMusic(ComboBox comboNote, NumericUpDown scale)
        {
            var note = (NoteEnum)comboNote.SelectedIndex;
            var result = sheetMusicService.GetNoteInSheetMusic(note, scale);

            return result;
        }

        public void DrawFigure(Panel pentagram, Image figure, NoteInSheetMusic note)
        {
            sheetMusicService.DrawFigure(pentagram, figure, note);
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
