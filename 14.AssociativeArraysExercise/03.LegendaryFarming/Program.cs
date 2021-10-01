using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            int shardsResultNeeded = 250;
            int fragmentsResultNeeded = 250;
            int motesResultNeeded = 250;
            int fragmentsResult = 0;
            int motesResult = 0;
            int shardsResult = 0;
            int result = 0;

            bool isObtained = false;

            Dictionary<string, int> remainingKeyMaterials = new Dictionary<string, int>();
            remainingKeyMaterials.Add("shards", 0);
            remainingKeyMaterials.Add("motes", 0);
            remainingKeyMaterials.Add("fragments", 0);
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                if (isObtained)
                {
                    break;
                }

                string[] line = Console.ReadLine()
                                        .ToLower()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

               
                for (int i = 0; i < line.Length; i+=2)
                {
                    int quantity = 0;
                    string material = string.Empty;
                    quantity = int.Parse(line[i]);
                    material = line[i+1];



                    if (material == "shards")
                    {
                        remainingKeyMaterials[material] += quantity;
                        shardsResult += quantity;

                        if (shardsResult >= shardsResultNeeded)
                        {
                            result = shardsResult - shardsResultNeeded;
                            Console.WriteLine("Shadowmourne obtained!");
                            remainingKeyMaterials[material] = result;
                            isObtained = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        remainingKeyMaterials[material] += quantity;
                        fragmentsResult += quantity;

                        if (fragmentsResult >= fragmentsResultNeeded)
                        {
                            result = fragmentsResult - fragmentsResultNeeded;
                            Console.WriteLine("Valanyr obtained!");
                            remainingKeyMaterials[material] = result;
                            isObtained = true;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        remainingKeyMaterials[material] += quantity;
                        motesResult += quantity;

                    if (motesResult >= motesResultNeeded)
                        {
                            result =  motesResult - motesResultNeeded;
                            Console.WriteLine("Dragonwrath obtained!");
                            remainingKeyMaterials[material]  = result;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                        
                    }
                }

               
            }

            foreach (var item in remainingKeyMaterials.OrderByDescending(i=>i.Value)
                                                      .ThenBy(i=>i.Key))//
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
