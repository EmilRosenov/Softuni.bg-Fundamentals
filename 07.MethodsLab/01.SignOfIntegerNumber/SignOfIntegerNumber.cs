using System;

namespace SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
           

            PrintNumber(int.Parse(Console.ReadLine()));
        }

        static void PrintNumber(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");

            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
