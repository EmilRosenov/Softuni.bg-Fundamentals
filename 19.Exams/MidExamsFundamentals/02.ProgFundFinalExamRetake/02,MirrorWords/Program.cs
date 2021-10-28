using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pairPattern = @"(@|#)([A-z]{3,})\1{2}([A-z]{3,})(@|#)";

            Dictionary<string, string> validPairs = new Dictionary<string, string>();
            string input = Console.ReadLine();
            int counter = 0;
            //var regex = new Regex(pairPattern);
            string firstWordPattern = @"([A-z]{3,})";

            var matches = Regex.Matches(input, pairPattern);

            {
                foreach (Match item in matches)
                {
                    string firstWord = "";
                    string secondWord = "";
                    counter++;
                    if (item.Value.Contains('#'))
                    {
                        string[] valid = item.Value
                                    .Split('#', StringSplitOptions.RemoveEmptyEntries);
                         firstWord = valid[0];
                         secondWord = valid[1];
                    }
                    else if (item.Value.Contains('@'))
                    {
                        string[] valid = item.Value
                                    .Split('@', StringSplitOptions.RemoveEmptyEntries);
                         firstWord = valid[0];
                         secondWord = valid[1];
                    }
                    

                    
                    StringBuilder sb = new StringBuilder();

                    for (int i = secondWord.Length - 1; i >= 0; i--)
                    {
                        sb.Append(secondWord[i]);
                    }
                    string secondWordReversed = sb.ToString();

                    if (firstWord == secondWordReversed)
                    {
                        validPairs.Add(firstWord, secondWord);
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{counter} word pairs found!");
            }
            
            
            if (validPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            Console.WriteLine("The mirror words are:");
            int validPairsCount = 0;
            foreach (var what in validPairs)
            {
                
                validPairsCount++;
                if (validPairsCount != validPairs.Count)
                {
                    
                    Console.Write($"{what.Key} <=> {what.Value}, ");
                }
                else
                {
                    Console.Write($"{what.Key} <=> {what.Value}");
                }
                
            }


        }
    }
}
