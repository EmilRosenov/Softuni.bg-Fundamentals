using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredList = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputCommand = input.Split();
                string command = inputCommand[0];

                if (command =="register")
                {
                    string name = inputCommand[1];
                    string plate = inputCommand[2];

                    if (!registeredList.ContainsKey(name))
                    {
                        registeredList.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else if (command =="unregister")
                {
                    string name = inputCommand[1];

                    if (registeredList.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        registeredList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }

            }

            foreach (var user in registeredList)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
