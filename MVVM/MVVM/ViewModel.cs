using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVM
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double numberOne;

        public double NumberOne
        {
            get { return numberOne; }
            set
            {
                numberOne = value;
                OnPropertyChanged("NumberOne");
                OnPropertyChanged("Result");
            }
        }

        private double numberTwo;

        public double NumberTwo
        {
            get { return numberTwo; }
            set
            {
                numberTwo = value;
                OnPropertyChanged("NumberTwo");
                OnPropertyChanged("Result");
            }
        }

        private double result;

        public double Result
        {
            get { return NumberOne + NumberTwo; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
