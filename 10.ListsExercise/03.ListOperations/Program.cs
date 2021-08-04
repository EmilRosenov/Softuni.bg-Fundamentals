using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperationsSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            string[] command = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "INSERT":

                        if (int.Parse(command[2]) <0 || int.Parse(command[2]) > numbers.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                       
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                      
                        break;

                    case "REMOVE":
                        if (IsNotValid(int.Parse(command[1]), numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                            break;
                        }
                        

                    case "SHIFT":

                        if (command[1].ToUpper() == "LEFT")
                        {
                            if (IsNotValid(int.Parse(command[2]), numbers.Count))
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }
                            
                           
                            int numberRotations = int.Parse(command[2]);
                            //0 1 2 3 4 5
                           
                            for (int i = 0; i < numberRotations; i++)
                            {
                                int firstElement = numbers[0];

                                for (int j = 0; j < numbers.Count-1; j++)
                                {
                                    numbers[j] = numbers[j + 1]; 
                                }

                                numbers[numbers.Count - 1] = firstElement;
                                
                            }
                               
                        }
                        else if (command[1].ToUpper() == "RIGHT")
                        {
                            if (IsNotValid(int.Parse(command[2]), numbers.Count))
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }
                            else
                            {
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    int lastElement = numbers[numbers.Count - 1];

                                    for (int j = numbers.Count - 1; j > 0; j--)
                                    {
                                        numbers[j] = numbers[j - 1];
                                    }
                                    numbers[0] = lastElement;
                                }
                            }
                            
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        public static bool IsNotValid(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
