using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> listItems = new List<string>();

            foreach (var element in input)
            {
                listItems.Add(element);
            }


            
            while (true)
            {

                string[] inputCommandAndItem = Console.ReadLine().Split(" - ");
                string command = inputCommandAndItem[0];

                if (command == "Collect")
                {
                    string item = inputCommandAndItem[1];

                    if (listItems.Contains(item))
                    {
                        continue;
                    }

                    listItems.Add(item);
                }
                else if (command == "Drop")
                {
                    string item = inputCommandAndItem[1];

                    if (listItems.Contains(item))
                    {
                        listItems.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string item = inputCommandAndItem[1];
                    string[] twoItems = item.Split(":").ToArray();
                    string oldItem = twoItems[0];
                    string newItem = twoItems[1];

                    if (!listItems.Contains(oldItem))
                    {
                        continue;
                    }

                    int indexOfOlditem = listItems.IndexOf(oldItem);
                    listItems.Insert(indexOfOlditem + 1, newItem);
                }
                else if (command=="Renew")
                {
                    string item = inputCommandAndItem[1];

                    if (listItems.Contains(item))
                    {
                        listItems.Remove(item);
                        listItems.Add(item);
                    }
                }

                if (command == "Craft!")
                {
                    break;
                }




            }

            Console.WriteLine(string.Join(", ", listItems));
        }
    }
}
