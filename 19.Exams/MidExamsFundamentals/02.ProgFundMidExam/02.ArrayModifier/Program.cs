using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();


            while (input != "end")
            {
                string[] commandInput = input.Split().ToArray();
                string command = commandInput[0];

                if (command == "swap")
                {
                    int inexOne = int.Parse(commandInput[1]);
                    int inexTwo = int.Parse(commandInput[2]);

                    int temp = array[inexOne];


                    array[inexOne] = array[inexTwo];
                    array[inexTwo] = temp;

                }
                else if (command == "multiply")
                {
                    int inexOne = int.Parse(commandInput[1]);
                    int inexTwo = int.Parse(commandInput[2]);

                    array[inexOne] *= array[inexTwo];

                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
