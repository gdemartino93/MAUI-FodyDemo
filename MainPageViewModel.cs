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
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int firstNumber;
        private int secondNumber;
        private int result;

        public event PropertyChangedEventHandler? PropertyChanged;

        //commands
        public ICommand AddCommand { get;}
        //props
        public int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                if (firstNumber != value)
                {
                    firstNumber = value;
                    OnPropertyChanged(nameof(FirstNumber));
                }
            }
        }
        public int SecondNumber
        {
            get { return secondNumber; }
            set
            {
                if(secondNumber != value)
                {
                    secondNumber = value;
                    OnPropertyChanged(nameof(SecondNumber));
                }
            }
        }
        public int Result
        {
            get { return result; }
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public MainPageViewModel()
        {
            AddCommand = new Command(ExecuteAdd);
        }

        protected void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        
        private void ExecuteAdd()
        {
            Result = FirstNumber + SecondNumber;
        }
    }
}
