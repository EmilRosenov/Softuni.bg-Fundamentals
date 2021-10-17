using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"(?<name>([A-Za-z]+))"; ;
            string distancePattern = @"\d";

            List<string> participants = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> nameAndDistance = new Dictionary<string, int>(3);

            string input = Console.ReadLine();

            while (input!= "end of race")
            {
                var matchNames = Regex.Matches(input, namePattern);
                var matchDistance = Regex.Matches(input, distancePattern);
                StringBuilder sb = new StringBuilder();
                foreach (Match item in matchNames)
                {
                    
                    sb.Append(item);
                 
                }
                string blah = sb.ToString();

                if (participants.Contains(blah))
                {
                    
                    int sum = 0;

                    foreach (Match digit in matchDistance)
                    {
                        sum += int.Parse(digit.Value);
                    }

                    if (nameAndDistance.ContainsKey(blah))
                    {
                        nameAndDistance[blah] += sum;
                    }
                    else
                    {
                        nameAndDistance.Add(blah, 0);
                        nameAndDistance[blah] = sum;
                    }
                    
                }

                input = Console.ReadLine();
            }

            nameAndDistance = nameAndDistance.OrderByDescending(x => x.Value)
                                             .ToDictionary(x => x.Key, y => y.Value);

            int counter = 0;

            foreach (var name in nameAndDistance.Keys)
            {
                counter++;

                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {name}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {name}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {name}");
                    return;
                }
            }
        }
    }
}
