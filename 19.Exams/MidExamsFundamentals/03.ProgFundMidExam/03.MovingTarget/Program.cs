using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();


            while (input != "End")
            {
                string[] line = input.Split().ToArray();

                string command = line[0];

                if (command == "Shoot")
                {
                    int index = int.Parse(line[1]);
                    int power = int.Parse(line[2]);

                    if (index < 0 || index > sequence.Count - 1)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    sequence[index] -= power;

                    if (sequence[index] <= 0)
                    {
                        int removeIndex = index;
                        sequence.RemoveAt(removeIndex);
                    }

                }
                else if (command == "Add")
                {
                    int index = int.Parse(line[1]);
                    int value = int.Parse(line[2]);

                    if (index < 0 || index > sequence.Count - 1)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        sequence.Insert(index, value);
                    }

                }
                else if (command == "Strike")
                {
                    int index = int.Parse(line[1]);
                    int radius = int.Parse(line[2]);

                    int leftIndexToRemove = index - radius;
                    int rightIndexToRemove = index + radius;

                    if (leftIndexToRemove < 0 || leftIndexToRemove > sequence.Count - 1
                       || rightIndexToRemove < 0 || rightIndexToRemove > sequence.Count - 1)
                    {
                        Console.WriteLine("Strike missed!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        sequence.RemoveRange(leftIndexToRemove, radius + radius + 1);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", sequence));
        }
    }
}
