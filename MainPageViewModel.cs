using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_FodyDemo
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        // implementing manually INotifyPropertyChanged
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        //commands
        public ICommand AddCommand { get;}
        public MainPageViewModel()
        {
            AddCommand = new Command(ExecuteAdd);
        }
        
        private void ExecuteAdd()
        {
            Result = FirstNumber + SecondNumber;
        }
    }
}
