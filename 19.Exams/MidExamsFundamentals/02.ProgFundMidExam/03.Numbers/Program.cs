using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();
            double average = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                average += sequence[i];
            }

            average = average / sequence.Count;
            

            List<int> topFive = new List<int>(5);

            if (sequence.Count == 1)
            {
                Console.WriteLine("No");
                return;
            }

            if (sequence.Count < topFive.Count)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] > average) //&& sequence.Count > 5)
                    {
                        topFive.Add(sequence[i]);
                    }
                }
            }
            

           if (sequence.Count >= topFive.Count)
           {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] > average) //&& sequence.Count > 5)
                    {
                        topFive.Add(sequence[i]);
                    }
                }

                while (topFive.Count-1 > 4)
                {
                    topFive.Remove(topFive.Min());
                }
           }

            Console.WriteLine(string.Join(" ",topFive.OrderByDescending(x=>x)));
        }
    }
}
