using ArduinoCodeGenerator.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArduinoCodeGenerator.Entities
{
    public class NoteInSheetMusicModel
    {
        public NoteEnum Note { get; set; }

        public int Scale { get; set; }

        public FigureEnum Duration { get; set; }

        public bool Pause { get; set; }

        public NoteInSheetMusicModel()
        {
        }
    }
}
