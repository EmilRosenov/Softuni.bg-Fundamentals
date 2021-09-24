using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split()
                            .Select(double.Parse).ToArray();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            foreach (var item in input)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            foreach (var pairs in dictionary)
            {
                Console.WriteLine(pairs.Key + " -> " + pairs.Value);
            }


        }
    }
}
