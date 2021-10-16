using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>(?:[0-2][0-9])|(?:[3][0-1]))((:?[-]|[\/]|[.]))(?<month>([A-Z]{1}[a-z]{2}))\1(?<year>([\d]{4}))\b";
            var dates = Console.ReadLine();
            //var regex = new Regex(pattern);

            var matches = Regex.Matches(dates, pattern);

            foreach (Match item in matches)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
