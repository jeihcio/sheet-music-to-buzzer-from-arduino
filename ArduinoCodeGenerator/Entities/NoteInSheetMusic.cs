using ArduinoCodeGenerator.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCodeGenerator.Entities
{
    class NoteInSheetMusic
    {
        public NoteEnum Note { get; set; }

        public int Scale { get; set; }
    }
}
