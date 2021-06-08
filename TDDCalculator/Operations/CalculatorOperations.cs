using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCalculator.Operations
{
    public class CalculatorOperations
    {



        #region Methods

        public static int Add(int x, int y)
        {
            return x + y;
        }


        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }


        public static double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return (x * 1.0) / y;
        }

        #endregion



    }
}
