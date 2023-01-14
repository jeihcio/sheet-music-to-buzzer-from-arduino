using ArduinoCodeGenerator.Entities;
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

        private int GetMarginNote(FigureEnum figure, NoteInSheetMusic note)
        {
            if (figure == FigureEnum.Semibreve) return 0;

            var IsRotatedImage = IsRotateImage(figure, note);
            var result = IsRotatedImage ? 0 : -43;

            return result;
        }

        private int GetTopNote(Image image, NoteInSheetMusic note, FigureEnum figure, bool isPause)
        {
            int[] topDoScale = {
                51, // do2
                0,  // do3
                -51, // do4
                -101, // do5
            };

            int[] notes =
            {
                0, // do
                //0, // do #
                1, // ré
                //1, // ré #,
                2, // mi
                3, // fá
                //3, // fá #
                4, // sol
                //4, // sol #
                5, // lá
                //5, // lá #
                6  // si
            };

            int[] pauses =
            {
                108, // Semibreve
                110, // Minimum
                94, // Quarter Note
                106, // Eighth Note
                106, // Sixteenth Note
            };

            int top = 0;
            var startPentagram = 160;

            if (isPause)
            {
                top = pauses[(int)figure];
            }
            else
            {
                int marginNote = GetMarginNote(figure, note);
                var topScale = startPentagram + topDoScale[note.Scale - 2];

                int offset = -7;
                int topNote = (offset * notes[(int)note.Note]) + marginNote;
                top = topScale + topNote;
            }

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

        private bool IsRotateImage(FigureEnum figure, NoteInSheetMusic note)
        {
            var scaleDo4 = 4;

            if (figure == FigureEnum.Semibreve) return false;
            if (note.Scale < scaleDo4 && note.Note != NoteEnum.NoteSi) return false;

            return true;
        }

        public void RotateImageIfNeeded(Image image, FigureEnum figure, NoteInSheetMusic note)
        {
            if (IsRotateImage(figure, note))
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        public Image GetImage(FigureEnum figure, NoteInSheetMusic note, bool isPause)
        {
            Image result = null;
            switch (figure)
            {
                case FigureEnum.Semibreve:
                    result = isPause ? Resources.semibrevePause : Resources.semibreve;
                    break;

                case FigureEnum.Minimum:
                    result = isPause ? Resources.minimumPause : Resources.minimum;
                    break;

                case FigureEnum.QuarterNote:
                    result = isPause ? Resources.quarterNotePause : Resources.quarterNote;
                    break;

                case FigureEnum.EighthNote:
                    result = isPause ? Resources.eighthNotePause : Resources.eighthNote;
                    break;

                case FigureEnum.SixteenthNote:
                    result = isPause ? Resources.sixteenthNotePause : Resources.sixteenthNote;
                    break;
            }

            RotateImageIfNeeded(result, figure, note);
            return result;
        }

        public NoteInSheetMusic GetNoteInSheetMusic(NoteEnum note, NumericUpDown scale, FigureEnum figure, bool isPause)
        {
            var result = new NoteInSheetMusic
            {
                Note = note,
                Scale = (int)scale.Value,
                Duration = figure,
                Pause = isPause
            };

            return result;
        }

        public void DrawFigure(Panel pentagram, Image image, NoteInSheetMusic note, FigureEnum figure, bool isPause)
        {
            var paddingLeft = 30;
            var top = GetTopNote(image, note, figure, isPause);

            var contentPane = new Panel
            {
                Width = image.Width,
                Height = image.Height,
                BackgroundImage = image,
                BackColor = Color.Transparent,
                Top = top
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
