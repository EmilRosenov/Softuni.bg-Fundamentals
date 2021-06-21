using System;
using System.Linq;

namespace zad8.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int firstElement = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    int secondElement = array[j];

                    if (firstElement + secondElement == number)
                    {
                        Console.WriteLine($"{firstElement} {secondElement}");
                    }
                }
            }
            



        }
    }
}
