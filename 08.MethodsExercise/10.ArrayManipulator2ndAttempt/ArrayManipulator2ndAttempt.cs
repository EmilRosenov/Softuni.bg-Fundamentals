using System;
using System.Linq;

namespace ArrayManipulator2ndAttempt
{
    class ArrayManipulator2ndAttempt
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            string input = " ";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                string action = command[0];

                if (action == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > array.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    ExchangeArray(array, index);
                }

                else if (action == "max")
                {
                    string evenOrOdd = command[1];

                    if (evenOrOdd == "even")
                    {
                        if (PrintMaxEven(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(PrintMaxEven(array)); 
                    }
                    else
                    {
                        if (PrintMaxOdd(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(PrintMaxOdd(array)); 
                    }
                }

                else if (action == "min")
                {
                    string evenOrOdd = command[1];

                    if (evenOrOdd == "even")
                    {
                        if (PrintMinEven(array) == -1)
                        {
                            
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(PrintMinEven(array)); 
                    }
                    else
                    {
                        if (PrintMinOdd(array) == -1)
                        {

                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(PrintMinOdd(array)); 
                    }
                }

                else if (action == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string evenOrOdd = command[2];

                    if (evenOrOdd == "even")
                    {
                        PrintFirstCountEven(array, count);
                    }
                    else
                    {
                        PrintFirstCountOdd(array, count);
                    }
                }
                else if (action == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string evenOrOdd = command[2];

                    if (evenOrOdd == "even")
                    {
                        PrintLastCountEven(array, count);
                    }
                    else
                    {
                        PrintLastCountOdd(array, count);
                    }
                }

            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");


            static void ExchangeArray(int[] arr, int index)
            {
                //1 3 5 7 9

                if (index > arr.Length - 1 || index < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                int[] firstArray = new int[arr.Length - 1 - index];
                int[] secondArr = new int[index + 1];

                int startIndex = 0;
                for (int i = arr.Length - (arr.Length - 1 - index); i < arr.Length; i++)
                {
                    firstArray[startIndex] = arr[i];
                    startIndex++;
                }

                for (int i = 0; i < index + 1; i++)
                {
                    secondArr[i] = arr[i];
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    arr[i] = firstArray[i];
                }
                int secondStartIndex = firstArray.Length - 1 + 1;
                for (int i = 0; i < secondArr.Length; i++)
                {
                    arr[secondStartIndex] = secondArr[i];
                    secondStartIndex++;
                }
            }

            static int PrintMaxEven(int[] arr)
            {
                int maxEvenElement = 0;
                int bestPosition = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    int currentElement = arr[i];

                    if (currentElement % 2 == 0)
                    {
                        if (currentElement >= maxEvenElement)
                        {
                            maxEvenElement = currentElement;
                            bestPosition = i;
                        }
                    }
                }
                int result = bestPosition;
                return result;

                
                

            }
            static int PrintMaxOdd(int[] arr)
            {
                int maxOddElement = 0;
                int bestPosition = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    int currentElement = arr[i];

                    if (currentElement % 2 != 0)
                    {
                        if (currentElement >= maxOddElement)
                        {
                            maxOddElement = currentElement;
                            bestPosition = i;
                        }
                    }
                }

                int result = bestPosition;
                return result;
                
            }

            static int PrintMinEven(int[] arr)
            {
                int minEvenElement = int.MaxValue;
                int index = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    
                    int currentElement = arr[i];

                    if (currentElement % 2 == 0)
                    {
                        if (currentElement <= minEvenElement)
                        {
                            minEvenElement = currentElement;
                            index = i;
                        }
                    }
                }
                int result = index;
                return result;
            }


            static int PrintMinOdd(int[] arr)
            {
                int minOddElement = int.MaxValue;
                int index = -1;
                for (int i = 0; i < arr.Length; i++)
                {

                    int currentElement = arr[i];

                    if (currentElement % 2 != 0)
                    {
                        if (currentElement <= minOddElement)
                        {
                            minOddElement = currentElement;
                            index = i;
                        }
                    }
                }
                int result = index;
                return result;
            }


            static void PrintFirstCountEven(int[] array, int count)
            {

                string numbers = " ";
                int counter = 0;
                
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] % 2 == 0)
                    {
                        numbers += array[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                

                else
                {
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }


            static void PrintFirstCountOdd(int[] array, int count)
            {

                string numbers = " ";
                int counter = 0;
                
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] % 2 != 0)
                    {
                        numbers += array[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                
                else
                {
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }

            static void PrintLastCountEven(int[] arr, int count)
            {
                string numbers = " ";
                int counter = 0;
                
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;
                        
                    }

                    if (counter == count)
                    {
                            break;
                    }
                   
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                //else if (counter ==1)
                //{
                //    Console.WriteLine("[" + result + "]");
                //}
                else
                {
                    Console.WriteLine("[" + string.Join(", ", result.Reverse()) + "]");
                }
            }

            static void PrintLastCountOdd(int[] arr, int count)
            {
                string numbers = " ";
                int counter = 0;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;

                    }

                    if (counter == count)
                    {
                        break;
                    }

                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                //else if (counter ==1)
                //{
                //    Console.WriteLine("[" + result + "]");
                //}
                else
                {
                    Console.WriteLine("[" + string.Join(", ", result.Reverse()) + "]");
                }
            }

        }
    }
}
