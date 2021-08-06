using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> secondHand = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            for (int i = 0; i < firstHand.Count; i++)
            {
                if (firstHand[i] > secondHand[i])
                {
                    firstHand.Add(firstHand[i]);
                    firstHand.Add(secondHand[i]);
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);
                    i = -1;
                    firstHand.Sum();

                }
                else if (secondHand[i] > firstHand[i])
                {
                    secondHand.Add(secondHand[i]);
                    secondHand.Add(firstHand[i]);
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);
                    i = -1;
                    secondHand.Sum();
                }
                else
                {
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);
                    i = -1;
                }

                if (firstHand.Count ==0 || secondHand.Count==0)
                {
                    if (firstHand.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                        break;
                    }
                }
            }
        }
    }
}
