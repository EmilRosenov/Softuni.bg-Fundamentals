using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToUpper() !="END")
            {
                switch (command[0].ToUpper())
                {
                    case "DELETE":
                        myList.RemoveAll(n => n == int.Parse(command[1]));
                        break;
                    case "INSERT":
                        myList.Insert(int.Parse(command[2]),
                            int.Parse(command[1]));
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(' ', myList));
        }
    }
}
