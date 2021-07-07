using System;

namespace Calculations
{
    class Calculations
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine(); //add, multiply, subtract, divide
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            PrintCalculationsResult(action, firstNumber, secondNumber);


        }

        static void PrintCalculationsResult(string input, double number, double anotherNumber)
        {
            double result = 0;

            if (input == "add")
            {
                result = number + anotherNumber;
            }
            if (input == "multiply")
            {
                result = number * anotherNumber;
            }
            if (input == "subtract")
            {
                result = number - anotherNumber;
            }
            if (input == "divide")
            {
                result = number / anotherNumber;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
