using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";

            string input = Console.ReadLine();
            List<string> emailsList = new List<string>();

            var matches = Regex.Matches(input, pattern);

            foreach (Match email in matches)
            {
                emailsList.Add(email.Value);
            }

            foreach (var item in emailsList)
            {
                Console.WriteLine(string.Join(Environment.NewLine, item));
            }
        }
    }
}
