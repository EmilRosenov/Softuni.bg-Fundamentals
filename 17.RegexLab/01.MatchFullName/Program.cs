using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regex_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<firstName>[A-Z]{1}[a-z]+)\b(?<delimiter>\s)\b(?<secondName>[A-Z]{1}[a-z]+)\b";

            string input = Console.ReadLine();//.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var matches = Regex.Matches(input, pattern);

            List<string> names = new List<string>();

            foreach (Match item in matches)
            {
                names.Add(item.Value);
            }
           

            Console.Write(string.Join(" ", names));
        }
    }
}
