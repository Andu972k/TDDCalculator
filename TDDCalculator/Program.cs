using System;

namespace TDDCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter First Number");

                string number1 = Console.ReadLine();

                Console.WriteLine("Choose Operation: *, /, + or -");

                string operation = Console.ReadLine();

                Console.WriteLine("Enter Second Number");

                string number2 = Console.ReadLine();

                Console.WriteLine(Calculator.Calculator.Calculate(number1, operation, number2) + "\n");
            }


        }
    }
}
