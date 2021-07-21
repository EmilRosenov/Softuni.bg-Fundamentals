using System;

namespace _07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);

        }

        private static void PrintMatrix(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= n; columns++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
