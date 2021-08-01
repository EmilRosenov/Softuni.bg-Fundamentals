using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            

            string command = Console.ReadLine();
            string action = " ";

            while (command !="end")
            {

                
                string[] input = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                action = input[0];


                List<int> resultList = new List<int>(numbers.Count);
                if (action == "Contains")
                {
                    int number = int.Parse(input[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2==0)
                        {
                            resultList.Add(numbers[i]);

                        }
                       
                    }
                    Console.WriteLine(string.Join(' ', resultList));
                }
                else if (action == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            resultList.Add(numbers[i]);

                        }

                    }
                    Console.WriteLine(string.Join(' ', resultList));
                }
                else if (action == "GetSum")
                {
                    numbers.Sum();
                    Console.WriteLine(numbers.Sum());
                }
                else if (action == "Filter")
                {
                    string comparer = input[1];
                    int number = int.Parse(input[2]);


                    if (comparer == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                resultList.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(string.Join(' ', resultList));
                    }

                    else if (comparer == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                resultList.Add(numbers[i]);
                            }
                        }


                        Console.WriteLine(string.Join(' ', resultList));

                    }
                    else if (comparer == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                resultList.Add(numbers[i]);
                            }
                        }


                        Console.WriteLine(string.Join(' ', resultList));

                    }
                    else if (comparer == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                resultList.Add(numbers[i]);
                            }
                        }


                        Console.WriteLine(string.Join(' ', resultList));

                    }

                }

                command = Console.ReadLine();
            }
        }
    }
}
