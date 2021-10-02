using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<double>> productAndPrice = new Dictionary<string, List<double>>();

            while (input!="buy")
            {
                string[] inputInfo = input
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                string product = inputInfo[0];
                double price = double.Parse(inputInfo[1]);
                double quantity = double.Parse(inputInfo[2]);
                
                if (!productAndPrice.ContainsKey(product))
                {
                    productAndPrice.Add(product, new List<double>() { price , quantity });
                }

                else 
                {
                    productAndPrice[product][0] = price;
                    productAndPrice[product][1] += quantity;
                }
                
                input = Console.ReadLine();
            }


            foreach (var item in productAndPrice)
            {
                double total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{ item.Key} -> { total:f2}");
            }

        }
    }
}
