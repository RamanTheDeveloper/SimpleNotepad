using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SimpleNotepad.ViewModels
{
    //About tab --> who created this etc.
    public class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout);
        }

        private void DisplayAbout()
        {
            //Will open help dialog
        }
    }
}
