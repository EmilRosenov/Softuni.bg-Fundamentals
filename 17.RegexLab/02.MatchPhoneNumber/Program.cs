using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";

            var phones = Console.ReadLine();

            
            var phoneMatches = Regex.Matches(phones,regex);

            var machedPhones = phoneMatches.Cast< Match > ()
                                           .Select(x => x.Value.Trim())
                                           .ToArray();
            Console.WriteLine(string.Join(", ", machedPhones));
        }
    }
}
