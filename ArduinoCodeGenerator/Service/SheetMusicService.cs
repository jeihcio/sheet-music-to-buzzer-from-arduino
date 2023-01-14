﻿using ArduinoCodeGenerator.Entities;
using ArduinoCodeGenerator.Entities.Enum;
using ArduinoCodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCodeGenerator.Service
{
    class SheetMusicService
    {
        private readonly int offset = 20;

        private int GetTopNote(NoteEnum note, int scale)
        {            
            int[] topDoScale = {
                50, // do2
                0,  // do3
                -48, // do4
                -100, // do5
            };

            int[] notes =
            {
                0, // do
                0, // do #
                1, // ré
                1, // ré #,
                2, // mi
                3, // fá
                3, // fá #
                4, // sol
                4, // sol #
                5, // lá
                5, // lá #
                6  // si
            };
           
            var startPentagram = 158;
            var topScale = startPentagram + topDoScale[scale - 2];

            int sizeNote = -8;
            int topNote = sizeNote * notes[(int)note];
            var top = topScale + topNote;

            return top;
        }

        private string OpenDialog()
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "JPEG Image (.jpeg)|*.jpeg"
            };
            saveFile.ShowDialog();

            return saveFile.FileName;
        }

        private bool SaveImageAs(string path, Panel pnlPentagram)
        {
            try
            {
                int width = pnlPentagram.Size.Width;
                int height = pnlPentagram.Size.Height;

                Bitmap bitMap = new Bitmap(width, height);
                pnlPentagram.DrawToBitmap(bitMap, new Rectangle(0, 0, width, height));

                bitMap.Save(path, ImageFormat.Jpeg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Image GetImage(FigureEnum figure, NoteInSheetMusic note)
        {
            Image result = null;
            switch (figure)
            {
                case FigureEnum.semibreve:
                    result = Resources.semibreve;
                    break;

                default:
                    result = null;
                    break;
            }

            return result;
        }

        public NoteInSheetMusic GetNoteInSheetMusic(NoteEnum note, NumericUpDown scale)
        {
            var result = new NoteInSheetMusic
            {
                Note = note,
                Scale = (int)scale.Value,
                Top = GetTopNote(note, (int)scale.Value)
            };

            return result;
        }

        public void DrawFigure(Panel pentagram, Image figure, NoteInSheetMusic note)
        {
            var paddingLeft = 30;

            var contentPane = new Panel
            {
                Width = figure.Width,
                Height = figure.Height,
                BackgroundImage = figure,
                BackColor = Color.Transparent,
                Top = note.Top
            };

            contentPane.Left = paddingLeft + pentagram.Width - contentPane.Width;

            pentagram.Width += contentPane.Width + offset;
            pentagram.Controls.Add(contentPane);
        }

        public void RemoveLastFigure(Panel pnlPentagram)
        {
            var indexLastFigure = pnlPentagram.Controls.Count - 1;
            if (indexLastFigure < 0) return;

            var lastFigure = pnlPentagram.Controls[indexLastFigure];

            pnlPentagram.AutoScroll = false;

            pnlPentagram.Width -= lastFigure.Width + offset;
            pnlPentagram.Controls.Remove(lastFigure);

            pnlPentagram.AutoScroll = true;
        }

        public void SaveImageAs(Panel pnlPentagram)
        {
            var path = OpenDialog();
            if (String.IsNullOrEmpty(path)) return;

            if (SaveImageAs(path, pnlPentagram))
                MessageBox.Show("Saved successfully!", "Save Image As...");
        }
    }
}
