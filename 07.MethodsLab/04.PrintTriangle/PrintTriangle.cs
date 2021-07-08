using System;

namespace PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTheShape(n);
        }


        static void PrintnumbersFrom1(int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i+" ");
            }
        }

        static void PrintTheShape(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintnumbersFrom1(i);
                Console.WriteLine();

            }

            for (int i = number - 1; i > 0; i--)
            {
                PrintnumbersFrom1(i);
                Console.WriteLine();
            }
        }
    }


    
}
