using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int counter = 0;
            string command = Console.ReadLine();
            bool ifWon = false;

            for (int i = 0; i < sequence.Count; i++)
            {
                while (command != "end")
                {
                    string[] pairs = command.Split(" ").ToArray();

                    int firstIndex = int.Parse(pairs[0]);
                    int secondIndex = int.Parse(pairs[1]);
                    

                    counter++;

                    if (firstIndex < 0 || firstIndex > sequence.Count - 1
                        || secondIndex < 0 || secondIndex > sequence.Count - 1)
                    {
                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                        int halfWaySequenceIndex = (sequence.Count + 1) / 2;
                        sequence.Insert(halfWaySequenceIndex , $"-{counter}a");
                        sequence.Insert(halfWaySequenceIndex + 1, $"-{counter}a");

                    }

                   else if (sequence[firstIndex] == sequence[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[secondIndex]}!");

                        if (firstIndex-1 >=0)
                        {
                            sequence.RemoveAt(firstIndex);
                            sequence.RemoveAt(secondIndex);
                        }
                        else
                        {
                            sequence.RemoveAt(firstIndex);
                            if (secondIndex - 1 < 0)
                            {
                                sequence.RemoveAt(firstIndex);
                            }
                            else
                            {
                                sequence.RemoveAt(secondIndex-1);
                            }
                        }
                        
                    }
                    else if (sequence[firstIndex] != sequence[secondIndex])
                    {
                        Console.WriteLine($"Try again!");
                       
                    }
                    if (sequence.Count == 0)
                    {
                       
                        ifWon = true;
                        break;
                    }

                    command = Console.ReadLine();
                }

                if (sequence.Count != 0)
                {
                    break;
                }
            }

            if (ifWon)
            {
                Console.WriteLine($"You have won in {counter} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }
            
        }
    }
}
