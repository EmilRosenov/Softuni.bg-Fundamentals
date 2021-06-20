using System;
using System.Linq;

namespace zad7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            //2 1 1 2 3 3 2 2 2 1
            int length = 0;
            int maxLenght = 0;
            int start = 0;
            int bestStart = 0;

            for (int i = 0; i < array.Length; i++)
            {
                length = 1;
                int firstElement = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    int secondElement = array[j];

                    if (firstElement == secondElement)
                    {
                        length++;
                        start = i;
                    }
                    else
                    {
                        length = 1;
                        break;
                    }
                    if (length > maxLenght)
                    {
                        maxLenght = length;
                        bestStart = start;
                    }
                } 
            }
            for (int k = bestStart; k < bestStart + maxLenght; k++)
            {
                Console.Write(array[k] + " ");
            }
        }
    }
}
