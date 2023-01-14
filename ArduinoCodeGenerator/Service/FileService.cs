﻿using ArduinoCodeGenerator.Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        public bool ExportFile(List<NoteInSheetMusicModel> listNoteInSheetMusic, decimal bpm)
        {
            var filter = "Json-File | *.json";
            var path = dialogService.SaveDialog(filter);
            if (String.IsNullOrEmpty(path)) return false;

            var exportFile = new ExportFileModel()
            {
                BPM = bpm,
                listNoteInSheetMusic = listNoteInSheetMusic
            };

            try
            {
                var file = JsonConvert.SerializeObject(exportFile, Formatting.Indented);
                File.WriteAllText(path, file);

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }            
        }
    }
}
