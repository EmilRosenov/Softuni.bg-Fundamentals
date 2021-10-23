using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string line = Console.ReadLine();

            while (line!="Go Shopping!")
            {
                string[] inputLine = line.Split();
                string command = inputLine[0];

                if (command == "Urgent")
                {
                    string product = inputLine[1];

                    if (!shoppingList.Contains(product))
                    {
                        shoppingList.Insert(0, product);
                    }
                    else
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Unnecessary")
                {
                    string product = inputLine[1];

                    if (!shoppingList.Contains(product))
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        shoppingList.Remove(product);
                    }
                }
                else if (command == "Correct")
                {
                    string oldProduct = inputLine[1];
                    string newProduct = inputLine[2];

                    if (!shoppingList.Contains(oldProduct))
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    
                    int indexOfOldProduct = shoppingList.IndexOf(oldProduct);
                    shoppingList.Remove(oldProduct);
                    shoppingList.Insert(indexOfOldProduct, newProduct);



                }
                else if (command =="Rearrange")
                {
                    string product = inputLine[1];

                    if (!shoppingList.Contains(product))
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        shoppingList.Remove(product);
                        shoppingList.Add(product);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
