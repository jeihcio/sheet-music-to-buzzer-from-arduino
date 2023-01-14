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
        private readonly FileService fileService;
        private readonly List<NoteInSheetMusic> listNoteInSheetMusic;

        public MainController()
        {
            fileService = new FileService();
            sheetMusicService = new SheetMusicService();            
            listNoteInSheetMusic = new List<NoteInSheetMusic>();
        }

        public void AddFigure(Panel pnlPentagram, ComboBox cmbNote, ComboBox cmbFigure, NumericUpDown numberScale, bool isPause)
        {
            var figure = (FigureEnum)cmbFigure.SelectedIndex;
            var note = (NoteEnum)cmbNote.SelectedIndex;

            var noteScale = sheetMusicService.GetNoteInSheetMusic(note, numberScale, figure, isPause);
            var image = sheetMusicService.GetImage(figure, noteScale, isPause);

            sheetMusicService.DrawFigure(pnlPentagram, image, noteScale, figure, isPause);
            listNoteInSheetMusic.Add(noteScale);
        }

        public void RemoveLastFigure(Panel pnlPentagram)
        {
            var last = listNoteInSheetMusic.LastOrDefault();

            sheetMusicService.RemoveLastFigure(pnlPentagram);
            listNoteInSheetMusic.Remove(last);
        }

        public void SaveImageAs(Panel pnlPentagram)
        {
            if (sheetMusicService.SaveImageAs(pnlPentagram))
                MessageBox.Show("Saved successfully!", "Save Image As...");
        }

        public void ExportFile()
        {
            if (fileService.ExportFile(listNoteInSheetMusic))
                MessageBox.Show("Saved successfully!", "Exporte file");
        }
    }
}
