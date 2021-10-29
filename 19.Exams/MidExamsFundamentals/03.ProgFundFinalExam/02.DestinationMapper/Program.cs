using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"((=+)|(\/+))[A-Z]{1}[A-z]{2,}\1";

            var matches = Regex.Matches(input, pattern);
            //string pointsPattern = @"[A-Z]{1}[A-z]{2,}";
           
            int travelPointsSum = 0;
            foreach (Match item in matches)
            {
                travelPointsSum += (item.Length-2);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Destinations: ");
            sb.Append(string.Join(", ", matches));
            sb.Replace("=", "");
            sb.Replace("/", "");
            

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Travel Points: {travelPointsSum}");
        }
    }
}
