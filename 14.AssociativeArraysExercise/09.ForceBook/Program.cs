using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ forceSide} | { forceUser}
            //{ forceUser} -> { forceSide}

            Dictionary<string, List<string>> forceSideList
                                = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            string notCurrent = string.Empty;
            string current = string.Empty;
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] inputInfo = input.Split(" | ");
                    string forceSide = inputInfo[0];
                    string user = inputInfo[1];

                    if (!forceSideList.ContainsKey(forceSide))
                    {
                        forceSideList.Add(forceSide, new List<string>());
                        forceSideList[forceSide].Add(user);
                    }
                    else if (forceSideList.ContainsKey(forceSide))
                    {
                        forceSideList[forceSide].Add(user);
                    }

                    
                    else 
                    {
                        input = Console.ReadLine();
                        continue;
                    } 
                }
                else if (input.Contains("->"))
                {
                    string[] inputInfo = input.Split(" -> ");
                    string user = inputInfo[0];
                    string forceSide = inputInfo[1];

                   
                    foreach (var item in forceSideList)
                    {
                        
                        if (item.Value.Contains(user))
                        {
                            item.Value.Remove(user);
                        }
                    }
                    
                    if (!forceSideList.ContainsKey(forceSide))
                    {
                        forceSideList.Add(forceSide, new List<string>());
                        forceSideList[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                    else if (!forceSideList[forceSide].Contains(user))
                    {
                        forceSideList[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var side in forceSideList.OrderBy(s => s.Value.Count).ThenBy(s => s.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}," +
                                       $" Members: {side.Value.Count}");

                    foreach (var member in side.Value.OrderBy(s => s))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }

            }
        }
    }
}
