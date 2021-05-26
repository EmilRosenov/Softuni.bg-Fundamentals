using System;

namespace _07.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int start = 1;

            for (int rows = 1; rows <= num; rows++)
            {

                for (int cows = 1; cows <= start; cows++)
                {
                    Console.Write(start + " ");

                }
                Console.WriteLine();
                start++;
            }
        }
    }
}
