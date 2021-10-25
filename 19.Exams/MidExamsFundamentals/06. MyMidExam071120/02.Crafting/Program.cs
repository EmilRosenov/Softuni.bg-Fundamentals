using System;
using System.Linq;

namespace _02.Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] particles = line.Split("|").ToArray();
            string temp = " ";

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                string command = input[0];

                if (command == "Done")
                {
                    break;
                }

                if (command =="Move")
                {
                    string direction = input[1];
                    int indexAt = int.Parse(input[2]);

                    if (direction =="Right")
                    {
                        if (indexAt < 0 || indexAt >= particles.Length - 1)
                        {
                            continue;
                        }

                        temp = particles[indexAt];
                        particles[indexAt] = particles[indexAt+1];
                        particles[indexAt+1] = temp;
                    }
                    else
                    {
                        if (indexAt <= 0 || indexAt > particles.Length - 1)
                        {
                            continue;
                        }
                        temp = particles[indexAt];
                        particles[indexAt] = particles[indexAt -1];
                        particles[indexAt -1] = temp;
                    }
                }
                else if (command=="Check")
                {
                    string status = input[1];

                    if (status=="Even")
                    {
                        for (int i = 0; i < particles.Length; i++)
                        {
                            if (i%2==0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < particles.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"You crafted {string.Join("", particles)}!");
        }
    }
}
