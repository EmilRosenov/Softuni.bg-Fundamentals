using System;
using System.Numerics;

namespace BigFactorial2ndAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.Calculate(number));
            
        }
    }

    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
