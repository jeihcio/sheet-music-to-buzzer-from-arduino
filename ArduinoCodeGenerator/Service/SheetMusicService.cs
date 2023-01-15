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
        private readonly DialogService dialogService;

        public SheetMusicService()
        {
            dialogService = new DialogService();
        }

        private int GetMarginNote(FigureEnum figure, NoteInSheetMusicModel note, bool isPause)
        {
            if (figure == FigureEnum.Semibreve) return 0;

            var IsRotatedImage = IsRotateImage(figure, note, isPause);
            var result = IsRotatedImage ? 0 : -43;

            return result;
        }

        private int GetTopNote(Image image, NoteInSheetMusicModel note, FigureEnum figure, bool isPause)
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
                int marginNote = GetMarginNote(figure, note, isPause);
                var topScale = startPentagram + topDoScale[note.Scale - 2];

                int offset = -7;
                int topNote = (offset * notes[(int)note.Note]) + marginNote;
                top = topScale + topNote;
            }

            return top;
        }

        private string OpenDialog()
        {
            var filter = "JPEG Image (.jpeg)|*.jpeg";
            return dialogService.SaveDialog(filter);
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

        private bool IsRotateImage(FigureEnum figure, NoteInSheetMusicModel note, bool isPause)
        {
            var scaleDo4 = 4;

            if (figure == FigureEnum.Semibreve) return false;
            if (isPause) return false;
            if (note.Scale < scaleDo4 && note.Note != NoteEnum.NoteSi) return false;

            return true;
        }

        private void DrawDash(Image image, int y, int width)
        {
            using (Graphics graphic = Graphics.FromImage(image))
            {
                var x = 0;              
                var height = 3;

                Brush brush = new SolidBrush(Color.Black);
                Rectangle rectangle = new Rectangle(x, y, width, height);

                graphic.FillRectangle(brush, rectangle);
            }
        }

        public void AddDashIfNeeded(Image image, FigureEnum figure, NoteInSheetMusicModel note, bool isPause)
        {
            if (isPause) return;

            var scaleDo3 = 3;
            var scaleDo4 = 4;

            // dash at the head of the note
            if ((note.Note == NoteEnum.NoteDo && note.Scale == scaleDo3) || 
                ((note.Note == NoteEnum.NoteLa || note.Note == NoteEnum.NoteSi) && note.Scale == scaleDo4))
            {
                var y = figure == FigureEnum.Semibreve ? 7 : 51;
                var width = figure == FigureEnum.Semibreve ? 32: 26;

                DrawDash(image, y, width);
            }

            // dash on the stem of the note
            if (note.Note == NoteEnum.NoteSi && note.Scale == scaleDo4)
            {

            }
        }

        public void RotateImageIfNeeded(Image image, FigureEnum figure, NoteInSheetMusicModel note, bool isPause)
        {
            if (IsRotateImage(figure, note, isPause))
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        public Image GetImage(FigureEnum figure, NoteInSheetMusicModel note, bool isPause)
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

            AddDashIfNeeded(result, figure, note, isPause);
            RotateImageIfNeeded(result, figure, note, isPause);

            return result;
        }

        public NoteInSheetMusicModel GetNoteInSheetMusic(NoteEnum note, int scale, FigureEnum figure, bool isPause)
        {
            var result = new NoteInSheetMusicModel
            {
                Note = note,
                Scale = scale,
                Duration = figure,
                Pause = isPause
            };

            return result;
        }

        public void DrawFigure(Panel pentagram, Image image, NoteInSheetMusicModel note, FigureEnum figure, bool isPause)
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

        public void RemoveAll(Panel pnlPentagram)
        {
            var length = pnlPentagram.Controls.Count;
            for (int i = 0; i < length; i++)
                RemoveLastFigure(pnlPentagram);
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

        public bool SaveImageAs(Panel pnlPentagram)
        {
            var path = OpenDialog();
            if (String.IsNullOrEmpty(path)) return false;

            return SaveImageAs(path, pnlPentagram);
        }
    }
}
