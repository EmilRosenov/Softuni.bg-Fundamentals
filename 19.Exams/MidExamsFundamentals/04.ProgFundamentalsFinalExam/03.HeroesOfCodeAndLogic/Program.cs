using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            var heroesDict = new Dictionary<string,
                                 Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int hitPoints = int.Parse(input[1]);
                int manaPoints = int.Parse(input[2]);

                heroesDict.Add(name, new Dictionary<string, int>());
                heroesDict[name].Add("HP", hitPoints);
                heroesDict[name].Add("MP", manaPoints);
            }

            string[] inputTwo = Console.ReadLine().Split(" - ").ToArray();

            while (inputTwo[0] != "End")
            {
                
                string command = inputTwo[0];

                if (command=="CastSpell")
                {
                    string name = inputTwo[1];
                    int MPNeeded = int.Parse(inputTwo[2]);
                    string spellName = inputTwo[3];

                    if (heroesDict[name]["MP"] >= MPNeeded)
                    {
                        heroesDict[name]["MP"] -= MPNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroesDict[name]["MP"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command== "TakeDamage")
                {
                    string name = inputTwo[1];
                    int damage = int.Parse(inputTwo[2]);
                    string atacker = inputTwo[3];
                    heroesDict[name]["HP"] -= damage;

                    if (heroesDict[name]["HP"] > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {atacker} and now has {heroesDict[name]["HP"]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {atacker}!");
                        heroesDict.Remove(name);
                    }
                    
                }
                else if (command == "Recharge")
                {
                    string name = inputTwo[1];
                    int increaseMPAmount = int.Parse(inputTwo[2]);
                    int amountForRecovery = 200 - heroesDict[name]["MP"];

                    heroesDict[name]["MP"] += increaseMPAmount;
                    if (heroesDict[name]["MP"] >= 200)
                    {
                        heroesDict[name]["MP"] = 200;
                        

                        Console.WriteLine($"{name} recharged for {amountForRecovery} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {increaseMPAmount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    string name = inputTwo[1];
                    int amountHP = int.Parse(inputTwo[2]);
                    int amountHPHealed = 100 - heroesDict[name]["HP"];

                    heroesDict[name]["HP"] += amountHP;
                    if (heroesDict[name]["HP"] >= 100)
                    {
                        heroesDict[name]["HP"] = 100;
                        Console.WriteLine($"{name} healed for {amountHPHealed} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {amountHP} HP!");
                    }
                    
                }

                inputTwo = inputTwo = Console.ReadLine().Split(" - ").ToArray();
            }

            heroesDict = heroesDict.OrderByDescending(x => x.Value["HP"]).ThenBy(y=>y.Key).ToDictionary(c => c.Key, u => u.Value);
            foreach (var name in heroesDict)
            {
                Console.WriteLine($"{name.Key}");
                foreach (var item in name.Value)
                {
                    Console.WriteLine($"  {item.Key}: {item.Value}");
                }
            }
        }
    }
}
