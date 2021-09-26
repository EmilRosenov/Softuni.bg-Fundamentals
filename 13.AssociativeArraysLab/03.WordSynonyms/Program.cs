using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary= 
                                                   new Dictionary<string, List<string>>();

            int numberOfPairs = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < numberOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();


                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonim);
                }
                else
                {
                    dictionary.Add(word, new List<string>());
                    dictionary[word].Add(synonim);
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}
