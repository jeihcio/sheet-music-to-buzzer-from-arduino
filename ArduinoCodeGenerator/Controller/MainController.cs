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
        private readonly List<NoteInSheetMusicModel> listNoteInSheetMusic;

        public MainController()
        {
            fileService = new FileService();
            sheetMusicService = new SheetMusicService();
            listNoteInSheetMusic = new List<NoteInSheetMusicModel>();
        }

        private void RemoveAll(Panel pnlPentagram)
        {
            sheetMusicService.RemoveAll(pnlPentagram);
            listNoteInSheetMusic.RemoveAll(x => x != null);
        }

        public void AddFigure(Panel pnlPentagram, Image image, NoteInSheetMusicModel noteScale, FigureEnum figure, bool isPause)
        {
            sheetMusicService.DrawFigure(pnlPentagram, image, noteScale, figure, isPause);
            listNoteInSheetMusic.Add(noteScale);
        }

        public void AddFigure(Panel pnlPentagram, ComboBox cmbNote, ComboBox cmbFigure, NumericUpDown numberScale, bool isPause)
        {
            var figure = (FigureEnum)cmbFigure.SelectedIndex;
            var note = (NoteEnum)cmbNote.SelectedIndex;

            var noteScale = sheetMusicService.GetNoteInSheetMusic(note, (int)numberScale.Value, figure, isPause);
            var image = sheetMusicService.GetImage(figure, noteScale, isPause);

            AddFigure(pnlPentagram, image, noteScale, figure, isPause);
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

        public void ExportFile(decimal bpm)
        {
            if (fileService.ExportFile(listNoteInSheetMusic, bpm))
                MessageBox.Show("Saved successfully!", "Exporte file");
        }

        public void ImportFile(Panel pnlPentagram, NumericUpDown numberBPM)
        {
            var file = fileService.OpenFile();
            if (file != null)
            {
                pnlPentagram.Visible = false;
                RemoveAll(pnlPentagram);

                numberBPM.Value = (int)file.BPM;
                file.listNoteInSheetMusic.ForEach((notes) =>
                {
                    var noteScale = sheetMusicService.GetNoteInSheetMusic(notes.Note, notes.Scale, notes.Duration, notes.Pause);
                    var image = sheetMusicService.GetImage(notes.Duration, noteScale, notes.Pause);

                    AddFigure(pnlPentagram, image, noteScale, notes.Duration, notes.Pause);
                });

                pnlPentagram.Visible = true;
                MessageBox.Show("Successfully imported!", "Exporte file");
            }
        }
    }
}
