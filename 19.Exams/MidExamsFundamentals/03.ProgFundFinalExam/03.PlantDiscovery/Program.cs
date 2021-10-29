using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plantDic = new Dictionary<string, Dictionary<string, double>>();
            var count = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->").ToArray();
                string flowerName = input[0];
                double rarityNumber = double.Parse(input[1]);

                if (plantDic.ContainsKey(flowerName))
                {
                    plantDic[flowerName]["Rarity"] = rarityNumber;
                }
                else
                {
                    plantDic.Add(flowerName, new Dictionary<string, double>());
                    plantDic[flowerName].Add("Rarity", rarityNumber);
                }
            }

            string[] inputInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int countRatingScores = 0;
            while (inputInfo[0] != "Exhibition")
            {
                string command = inputInfo[0].TrimEnd(':');
                if (command == "Rate")
                {

                    string flowerName = inputInfo[1];
                    double rating = double.Parse(inputInfo[3]);
                    if (rating > 10 || rating < 0)
                    {
                        Console.WriteLine("error");
                        inputInfo = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    }
                    if (plantDic[flowerName].ContainsKey("Rating"))
                    {
                        plantDic[flowerName]["Rating"] += rating;
                        countRatingScores++;
                        count[flowerName]++;
                    }
                    else
                    {
                        plantDic[flowerName].Add("Rating", rating);
                        countRatingScores = 1;
                        count[flowerName] = 1;
                    }
                }
                else if (command == "Update")
                {

                    string flowerName = inputInfo[1];
                    int newRarity = int.Parse(inputInfo[3]);
                    if (newRarity > 10 || newRarity < 0)
                    {
                        Console.WriteLine("error");
                        inputInfo = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    if (plantDic[flowerName].ContainsKey("Rarity"))
                    {
                        plantDic[flowerName]["Rarity"] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        inputInfo = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                }
                else if (command == "Reset")
                {

                    string flowerName = inputInfo[1];
                    if (!plantDic[flowerName].ContainsKey("Rating"))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        plantDic[flowerName]["Rating"] = 0;
                    }

                }
                else
                {
                    Console.WriteLine("error");
                }
                inputInfo = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            double flowerRatingCount = 0;
            var sorted = plantDic.OrderByDescending(x => x.Value["Rarity"])
                .ThenByDescending(y => y.Value["Rating"])
                .ToDictionary(a => a.Key, g => g.Value);

            Console.WriteLine("Plants for the exhibition:");
            var listNames = new List<string>();
            foreach (var item in sorted.Keys)
            {
                listNames.Add(item);
            }
            int counter = 0;
            foreach (var item in count)
            {
                flowerRatingCount = item.Value;

                foreach (var flowerRating in sorted.Values)
                {

                    flowerRating["Rating"] /= flowerRatingCount;
                    flowerRatingCount = 1;
                    Console.WriteLine($"- {listNames[counter]}; Rarity: {flowerRating["Rarity"]}; Rating: {flowerRating["Rating"]:f2}");
                    counter++;
                    if (counter == count.Count)
                    {
                        return;
                    }
                    //break;
                }
            }
        }
    }
}
