using ArduinoCodeGenerator.Entities;
using ArduinoCodeGenerator.Entities.Enum;
using ArduinoCodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCodeGenerator.Service
{
    class SheetMusicService
    {
        private int GetTopNote(NoteEnum note, int scale)
        {
            var topScale = 30 * scale;
            var top = topScale ;

            return topScale;
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
            var offset = 10;
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
    }
}
