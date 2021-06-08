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


        public static string Calculate(string equation)
        {

            string result = "";

            equation = RemoveWhitespaces(equation);

            if (CheckForInvalidSigns(equation))
            {
                return "Invalid Sign(s)";
            }


            if (equation.Contains("*"))
            {
                string[] numbers = equation.Split("*");
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);

                result = CalculatorOperations.Multiply(x, y).ToString();
            }

            if (equation.Contains("/"))
            {
                string[] numbers = equation.Split("/");
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);

                try
                {
                    result = CalculatorOperations.Divide(x, y).ToString();
                }
                catch (DivideByZeroException e)
                {
                    return "Can't divide by zero";
                }

                
            }

            if (equation.Contains("+"))
            {
                string[] numbers = equation.Split("+");
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);

                result = CalculatorOperations.Add(x, y).ToString();
            }

            if (equation.Contains("-"))
            {
                string[] numbers = equation.Split("-");
                int x = Int32.Parse(numbers[0]);
                int y = Int32.Parse(numbers[1]);

                result = CalculatorOperations.Subtract(x, y).ToString();
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
