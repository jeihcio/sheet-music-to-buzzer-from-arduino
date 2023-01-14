using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArduinoCodeGenerator.Entities
{
    public class ExportFileModel
    {
        public decimal BPM { get; set; }

        public List<NoteInSheetMusicModel> listNoteInSheetMusic { get; set; }
    }
}
