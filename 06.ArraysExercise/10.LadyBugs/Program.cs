using System;
using System.Linq;

namespace zad._10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < indexes.Length; i++)
            {
                int currentIndex = indexes[i];

                if (currentIndex >=0 && currentIndex < field.Length)
                {
                field[currentIndex] = 1; 

                }

            }
            //Console.WriteLine(string.Join(" ", field));

            string command = string.Empty;

            while ((command = Console.ReadLine()) !="end")
            {
                string[] input = command.Split();

                int ladyBugIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);

                if (field[ladyBugIndex] == 0 || ladyBugIndex < 0 || ladyBugIndex > field.Length)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "right")
                {

                    int landingIndex = ladyBugIndex + flyLength;

                    
                    if (landingIndex > field.Length - 1)
                    {
                        continue;
                    }

                    
                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex += flyLength;
                            if (landingIndex > field.Length -1)
                            {
                                break;
                            }
                        }
                    }

                    if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                    {
                        field[landingIndex] = 1;

                    }

                }
                else if (direction == "left")
                {
                    
                    int landingIndex = ladyBugIndex - flyLength;

                    if (landingIndex < 0)
                    {
                        continue;
                    }

                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex -= flyLength;
                            if (landingIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                    {
                    field[landingIndex] = 1;

                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
