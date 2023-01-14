using ArduinoCodeGenerator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCodeGenerator.Service
{
    class FileService
    {
        private readonly DialogService dialogService;

        public FileService()
        {
            dialogService = new DialogService();
        }

        public bool ExportFile(List<NoteInSheetMusic> listNoteInSheetMusic)
        {
            var filter = "XML-File | *.xml";
            var path = dialogService.SaveDialog(filter);
            if (String.IsNullOrEmpty(path)) return false;

            
            return true;
        }
    }
}
