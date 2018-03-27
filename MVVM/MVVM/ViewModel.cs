using MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using static MVVM.Model;

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
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
                Results.Add(new Model.Result() { Value = result });
            }
        }

        //! added using System.Collections.ObjectModel;
       public ObservableCollection<Result> Results { get; set; }

        //! Added using MVVM.Commands;
        public AddCommand AddCommand { get; set; }
        public SubtractCommand SubtractCommand { get; set; }
        public MultiplyCommand MultiplyCommand { get; set; }
        public DivideCommand DivideCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            AddCommand = new AddCommand(this);
            SubtractCommand = new SubtractCommand(this);
            MultiplyCommand = new MultiplyCommand(this);
            DivideCommand = new DivideCommand(this);

            Results = new ObservableCollection<Result>();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Add()
        {
            Result = Model.Add(NumberOne, NumberTwo);
        }

        public void Sustract()
        {
            Result = Model.Sustract(NumberOne, NumberTwo);
        }

        public void Multiply()
        {
            Result = Model.Multiply(NumberOne, NumberTwo);
        }

        public void Divide()
        {
            Result = Model.Divide(NumberOne, NumberTwo);
        }
    }
}
