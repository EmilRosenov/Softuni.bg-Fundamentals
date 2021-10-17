using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string starPattern = @"[SsTtAaRr]";
            int attackedPLanetsCount = 0;
            int destroyedPLanetsCount = 0;

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var matches = Regex.Matches(input, starPattern);
                int key = 0;

                foreach (Match letter in matches)
                {
                    key++;
                }

                string resultPattern = "";
                foreach (char letter in input)
                {
                    resultPattern += (char)(letter - key);
                }

                string inputPattern = @"[>-]?\w*@(?<n>([A-z]+))\w*[>-]?:(?<p>(\d+))[>-]?![>-]?(?<at>([A-Z]))\w*[>-]?!->[>-]?(?<sc>(\d+))\w*[>-]?";

                Match secondMatch = Regex.Match(resultPattern, inputPattern);

                if (secondMatch.Success)
                {
                    string planetName = secondMatch.Groups["n"].Value;
                    string planetPopulation = secondMatch.Groups["p"].Value;
                    string atackType = secondMatch.Groups["at"].Value;
                    string soldierCount = secondMatch.Groups["sc"].Value;

                    if (atackType == "A")  //&& inputPattern.Contains(atackType)
                    {
                        attackedPLanetsCount++;
                        attackedPlanets.Add(planetName);
                    }
                    else if (atackType == "D")
                    {
                        destroyedPLanetsCount++;
                        destroyedPlanets.Add(planetName);
                    }
                }
            
            }

            Console.WriteLine($"Attacked planets: {attackedPLanetsCount}");
            foreach (var planet in attackedPlanets.OrderBy(p=>p))
            {
                Console.WriteLine($"-> {planet}");
            }
            
            Console.WriteLine($"Destroyed planets: {destroyedPLanetsCount}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
