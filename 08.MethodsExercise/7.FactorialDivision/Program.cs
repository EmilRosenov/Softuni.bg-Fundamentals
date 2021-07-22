using System;

namespace _08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger =int.Parse(Console.ReadLine());

            double factorialFirstInt = GetFactorial(firstInteger);
            double factorialSecondInt = GetFactorial(secondInteger);
            double sum = factorialFirstInt / factorialSecondInt;
            Console.WriteLine($"{sum:f2}");
        }

        private static double GetFactorial(int number)
        {
           
                double result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                }
                return result;
        }
    }
}


