using SimpleNotepad.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.ViewModels
{
    public class MainViewModel
    {
        //Document that is saved laoded and hold editor text
        private DocumentModel _document;

        //Manages user input for document and format styles
        public EditorViewModel Editor { get; set; }

        //Manages saving and laoding text files
        public FileViewModel File { get; set; }

        //Manage help dialog
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }
    }
}
