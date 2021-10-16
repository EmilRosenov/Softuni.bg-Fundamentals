using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpressions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>([A-z]+))<<(?<price>(\d+\.?\d+?))!(?<quantity>(\d+))";
            List<string> furnitureName = new List<string>();
            double total = 0;

            while (input!="Purchase")
            {
                //var regex = new Regex(pattern);
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    //furnitureName.Add(match.Value); hubava greshka
                    furnitureName.Add(name);
                    total += price * quantity;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furnitureName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
