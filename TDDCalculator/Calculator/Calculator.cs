using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDDCalculator.Operations;

namespace TDDCalculator.Calculator
{
    public class Calculator
    {


        #region Methods


        public static string Calculate(string x, string operation, string y)
        {

            string result = "";

            x = RemoveWhitespaces(x);

            operation = RemoveWhitespaces(operation);

            y = RemoveWhitespaces(y);

            if (CheckForInvalidSigns(x) || CheckForInvalidSigns(operation) || CheckForInvalidSigns(y))
            {
                return "Invalid Sign(s)";
            }

            if (operation == "*")
            {
                result = CalculatorOperations.Multiply(Int32.Parse(x), Int32.Parse(y)).ToString();
            }

            if (operation == "/")
            {
                try
                {
                    result = CalculatorOperations.Divide(Int32.Parse(x), Int32.Parse(y)).ToString();
                }
                catch (DivideByZeroException e)
                {
                    return "Can't divide by zero";
                }
            }

            if (operation == "+")
            {
                result = CalculatorOperations.Add(Int32.Parse(x), Int32.Parse(y)).ToString();
            }

            if (operation == "-")
            {
                result = CalculatorOperations.Subtract(Int32.Parse(x), Int32.Parse(y)).ToString();
            }

            return $"= {result}";
        }


        #endregion


        #region HelpMethods

        private static string RemoveWhitespaces(string equation)
        {
            return String.Concat(equation.Where(c => !char.IsWhiteSpace(c)));
        }

        private static bool CheckForInvalidSigns(string equation)
        {
            char[] chars = equation.ToCharArray();

            for (int index = 0; index < chars.Length; index++)
            {
                if (chars[index] == '+' || chars[index] == '-' || chars[index] == '*' || chars[index] == '/')
                {
                    chars[index] = '0';
                }
            }

            foreach (char c in chars)
            {
                if (!char.IsNumber(c))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

    }
}
