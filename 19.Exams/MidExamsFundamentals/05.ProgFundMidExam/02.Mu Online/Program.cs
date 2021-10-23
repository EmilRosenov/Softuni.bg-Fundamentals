using System;
using System.Linq;

namespace zad2.Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            int myHealth = 100;
            int bitcoins = 0;
            bool isDead = false;
            int roomNumber = 0;
            string currentMonster = " ";

            string[] input = Console.ReadLine().Split("|").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] room = input[i].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string monster = room[0];
                int health = int.Parse(room[1]);

                roomNumber = i + 1;

                if (monster != "potion" && monster !="chest")
                {
                    myHealth -= health;

                    if (myHealth <= 0)
                    {
                        currentMonster = monster;
                        isDead = true;
                        break;
                    }

                    Console.WriteLine($"You slayed {monster}.");

                }
                else if (monster == "chest")
                {
                    bitcoins += health;
                    Console.WriteLine($"You found {health} bitcoins.");
                }

                else if (monster == "potion")
                {
                    if (myHealth + health >=100)
                    {
                        Console.WriteLine($"You healed for {100 - myHealth} hp.");
                        myHealth = 100;
                        
                    }
                    
                    else
                    {
                        myHealth += health;
                        Console.WriteLine($"You healed for {health} hp.");
                    }
                    Console.WriteLine($"Current health: {myHealth} hp.");  
                }
            }

            if (isDead)
            {
                Console.WriteLine($"You died! Killed by {currentMonster}.");
                Console.WriteLine($"Best room: {roomNumber}");
            }
            else
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {myHealth}");
            }
        }
    }
}
