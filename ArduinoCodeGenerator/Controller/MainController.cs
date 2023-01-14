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

        private Image GetImage(FigureEnum figure, NoteInSheetMusic note)
        {            
            return sheetMusicService.GetImage(figure, note);
        }

        private NoteInSheetMusic GetNoteInSheetMusic(ComboBox comboNote, NumericUpDown scale)
        {
            var note = (NoteEnum)comboNote.SelectedIndex;
            var result = sheetMusicService.GetNoteInSheetMusic(note, scale);

            return result;
        }

        public void DrawFigure(Panel pnlPentagram, ComboBox cmbNote, ComboBox cmbFigure, NumericUpDown numberScale)
        {
            var noteScale = GetNoteInSheetMusic(cmbNote, numberScale);
            var figure = (FigureEnum)cmbFigure.SelectedIndex;
            var image = GetImage(figure, noteScale);

            sheetMusicService.DrawFigure(pnlPentagram, image, noteScale, figure);
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
