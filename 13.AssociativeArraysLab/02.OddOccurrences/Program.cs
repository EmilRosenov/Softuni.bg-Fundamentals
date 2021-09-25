using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string wordInLowerCase = word.ToLower();
                if (dict.ContainsKey(wordInLowerCase))
                {
                    dict[wordInLowerCase]++;
                }
                else
                {
                    dict.Add(wordInLowerCase, 1);
                }
            }
            foreach (var words in dict)//.OrderByDescending(x=>x.Key))
            {
                if (words.Value % 2 != 0)
                {
                    Console.Write(words.Key + " ");
                }
                
            }
        }
    }
}
