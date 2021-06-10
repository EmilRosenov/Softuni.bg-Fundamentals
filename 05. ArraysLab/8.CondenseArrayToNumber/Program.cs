using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (firstArray.Length == 1)
            {
                Console.WriteLine(firstArray[0]);
                return;
            }

            else
            {
               
                while (firstArray.Length != 1) // did it with else if()before 
                {
                    int[] secondArray = new int[firstArray.Length - 1]; //was on top of while before...
                    for (int i = 0; i < firstArray.Length - 1; i++)
                    {
                        secondArray[i] = firstArray[i] + firstArray[i + 1];

                    }
                    firstArray = secondArray;

                }
                Console.WriteLine(firstArray[0]);  //thats why here the result was 12...  0 + 1;
            }

            

        }
    }
}
