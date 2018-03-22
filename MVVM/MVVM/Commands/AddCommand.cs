using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM.Commands
{
    public class AddCommand : ICommand
    {
        public ViewModel ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddCommand(ViewModel vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Add();
        }
    }
}
