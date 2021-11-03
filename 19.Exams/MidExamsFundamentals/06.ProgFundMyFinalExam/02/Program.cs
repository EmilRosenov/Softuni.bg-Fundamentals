using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> eggsDict = new Dictionary<string, string>();
            string pattern = @"((@|#)+([a-z]{3,})(@|#)*\W*\/+\d+\/+)";
            string input = Console.ReadLine();
            string colorPattern = @"[a-z]{3,}";
            string amountPattern = @"\d+";

            var matches = Regex.Matches(input, pattern);

            foreach (Match lineMatch in matches)
            {
                string correct = lineMatch.Value;

                var colorMatches = Regex.Matches(correct, colorPattern);

                foreach (Match color in colorMatches)
                {
                    
                    var amountMatches = Regex.Matches(correct, amountPattern);
                    foreach (Match amount in amountMatches)
                    {
                        if (eggsDict.ContainsKey(color.Value))
                        {
                            eggsDict[color.Value] = amount.Value;
                        }
                        else
                        {
                            eggsDict.Add(color.Value, amount.Value);
                        }
                        Console.WriteLine($"You found {amount.Value} {color.Value} eggs!");
                        break;
                    }
                }
            }

           //foreach (var item in eggsDict)
           //{
           //    Console.WriteLine($"You found {item.Value} {item.Key} eggs!");
           //}
            
        }
    }
}
