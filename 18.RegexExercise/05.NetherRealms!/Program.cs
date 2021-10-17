using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();

            string[] input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"[-+]?[0-9]+\.?[0-9]*";

            Regex numbersPattern = new Regex(pattern);

            foreach (var demon in input)
            {
                string filter = "0123456789+-*/.";

                int health = demon.Where(c => !filter.Contains(c)).Sum(c => c);
                double damage = CalculateDamage(numbersPattern, demon);

                demons.Add(new Demon { Name = demon, Health = health, Damage = damage });


            }

            foreach (var output in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine(output);
            }

        }

        private static double CalculateDamage(Regex numbersPattern, string demon)
        {
            MatchCollection numberMatches = numbersPattern.Matches(demon);
            double damage = 0.0;

            foreach (Match match in numberMatches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }

            return damage;
        }

        public class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Health} health, {Damage:f2} damage";
            }
        }
    }
}
