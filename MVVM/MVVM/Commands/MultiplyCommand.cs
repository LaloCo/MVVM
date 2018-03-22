using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM.Commands
{
    public class MultiplyCommand : ICommand
    {
        public ViewModel ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public MultiplyCommand(ViewModel vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Multiply();
        }
    }
}
