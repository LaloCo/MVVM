using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM
{
    public class Model
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Sustract(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        public class Result
        {
            public double Value { get; set; }

            public override string ToString()
            {
                return $"{this.Value}";
            }
        }
    }
}
