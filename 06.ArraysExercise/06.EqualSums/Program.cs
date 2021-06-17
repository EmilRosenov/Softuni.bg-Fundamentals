using System;
using System.Linq;

namespace zad6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            //1 2 3 3   - output   2
            //10 5 5 99 3 4 2 5 1 1 4   -- 3
            
            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }
                for (int k = i+1; k < array.Length; k++)
                {
                    sumRight += array[k];

                    
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
