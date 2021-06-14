using System;
using System.Linq;

namespace zad3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();
                int firstElement = currentArray[0];
                int secondElement = currentArray[1];
                if (i % 2 == 0)
                {
                    array1[i] = firstElement;
                    array2[i] = secondElement;
                }
                else
                {
                    array1[i] = secondElement;
                    array2[i] = firstElement;
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
