using System;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigNumber = int.Parse(Console.ReadLine());
            int otherNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyBigNumber(bigNumber, otherNumber));
        }

        static int MultiplyBigNumber(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result; 
        }
    }
}
