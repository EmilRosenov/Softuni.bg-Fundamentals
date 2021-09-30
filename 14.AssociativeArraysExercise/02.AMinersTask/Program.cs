using System;
using System.Collections.Generic;

namespace _02.AMinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resourceAndQuantity = new Dictionary<string, int>();
           
            while (input!="stop")
            {
                    int quantity = int.Parse(Console.ReadLine());

                        if (!resourceAndQuantity.ContainsKey(input))
                        {
                            resourceAndQuantity.Add(input, quantity);
                        }
                        else
                        {
                            resourceAndQuantity[input] += quantity;
                        }

                    input = Console.ReadLine();
               
            }

            foreach (var kvp in resourceAndQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
           
        }
    }
}
