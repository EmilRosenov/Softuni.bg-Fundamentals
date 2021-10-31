using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=)@#+([A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})@#+";
            var productAndGroup = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    

                    string filterPattern = @"\d";
                    var secondMatch = Regex.Matches(input, filterPattern);
                    string text = "";
                    foreach (Match item in secondMatch)
                    {
                        text += item.Value;
                    }
                    productAndGroup.Add(match.Value, text);
                    if (text == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {text}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

            //foreach (var item in productAndGroup.Values)
            //{
            //    if (item =="")
            //    {
            //
            //    }
            //}
        }
    }
}
