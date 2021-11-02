using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<ifOnlyNumber>(?<=^|[\d|\s])\d{1}(?<=[\d|\s]|\b))|\d";
            string emojiPattern = @"(\:{2}|\*{2})([A-Z]{1}[a-z]{2,})\1";
            string text = Console.ReadLine();
            List<string> emojiList = new List<string>();

            int coolTresholdSum = 1;
            int current = 1;

            var matches = Regex.Matches(text, pattern);

            foreach (Match digit in matches)
            {
                if (int.Parse(digit.Value)!=1)
                {
                    coolTresholdSum *= int.Parse(digit.Value);
                }
            }

            var emojiMatches = Regex.Matches(text, emojiPattern);
            int emojiCount = 0;
            emojiCount = emojiMatches.Count;
            

            foreach (var emoji in emojiMatches)
            {
                int emojiSUm = 0;
                foreach (var ch in emoji.ToString())
                {
                    if (ch ==':' || ch=='*')
                    {
                        emojiSUm += 0;
                    }
                    else
                    {
                        emojiSUm += (int)ch;
                    }
                    
                }

                if (emojiSUm >= coolTresholdSum)
                {
                    emojiList.Add(emoji.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolTresholdSum}");
            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");
            
            foreach (var item in emojiList)
            {
                Console.WriteLine(string.Join(Environment.NewLine,item +" "));
            }
        }
    }
}
