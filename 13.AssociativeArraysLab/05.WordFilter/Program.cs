using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            List<string> wordsList = new List<string>();

            wordsList = words.Where(w => w.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, wordsList));

        }
    }
}
