using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>(number);
            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                string[] action = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                counter++;

                if (action[2].ToUpper() !="NOT")
                {
                    if (guestList.Contains(action[0]))
                    {
                        Console.WriteLine($"{action[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(action[0]);
                    }
                    
                }
                else
                {
                    if (guestList.Contains(action[0]))
                    {
                        guestList.Remove(action[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{action[0]} is not in the list!");
                    }
                }
                if (counter == number)
                {
                    for (int j = 0; j < guestList.Count; j++)
                    {
                        Console.Write(guestList[j]);
                        Console.WriteLine();
                    }
                }
               
            }
        }
    }
}
