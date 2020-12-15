using SimpleNotepad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SimpleNotepad.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }
    }
}
