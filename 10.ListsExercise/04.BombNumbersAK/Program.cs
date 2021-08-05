using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbersAleksandarK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            int[] specialNumberAndPower = Console.ReadLine()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            int bombnmber = specialNumberAndPower[0];
            int power = specialNumberAndPower[1];

          
            for (int i = 0; i < myList.Count; i++)
            {
                int currentNumber = myList[i];

                if (currentNumber == bombnmber)
                {
                int startIndex = i - power;
                int endIndex = i + power;


                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > myList.Count - 1)
                    {
                        endIndex = myList.Count - 1;
                    }
                    int countItemsToRemove = endIndex - startIndex + 1;
                    myList.RemoveRange(startIndex, countItemsToRemove);

                    i = startIndex - 1;
                }
                
            }
            Console.WriteLine(string.Join(" ",myList.Sum()));
        }
    }
}
