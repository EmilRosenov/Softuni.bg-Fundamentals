using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int totalSales = 0;
            Dictionary<string, int> stockDict = new Dictionary<string, int>(); 
            while (inputArgs[0] != "Complete")
            {
                if (inputArgs[0] == "Complete")
                {

                    return;
                }
                string command = inputArgs[0];

                if (command=="Receive")
                {
                    int quantity = int.Parse(inputArgs[1]);
                    string food = inputArgs[2];

                    if (quantity<=0)
                    {
                        inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    if (!stockDict.ContainsKey(food))
                    {
                        stockDict.Add(food, quantity);
                    }
                    else
                    {
                        stockDict[food] += quantity;
                    }
                }
                else if (command == "Sell")
                {
                    int quantity = int.Parse(inputArgs[1]);
                    string food = inputArgs[2];
                    if (!stockDict.ContainsKey(food))
                    {
                        Console.WriteLine($"You do not have any {food}.");
                        inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    if (stockDict[food] < quantity)
                    {
                        Console.WriteLine($"There aren't enough {food}. You sold the last {stockDict[food]} of them.");
                        totalSales += stockDict[food];
                        stockDict[food] -= stockDict[food];
                        
                        stockDict.Remove(food);
                        //quantity = quantity - stockDict[food];
                    }
                    else
                    {
                        stockDict[food] -= quantity;
                        Console.WriteLine($"You sold {quantity} {food}.");
                        totalSales += quantity;
                        if (stockDict[food] <= 0)
                        {
                            stockDict.Remove(food);
                        }
                    }
                }
                
                inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            stockDict = stockDict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in stockDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine($"All sold: {totalSales} goods");
        }
    }
}
