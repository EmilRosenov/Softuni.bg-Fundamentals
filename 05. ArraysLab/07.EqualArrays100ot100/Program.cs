using System;
using System.Linq;

namespace _7.equalArrays100ot100prepisReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] firstArr = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            int[] secondArr = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])

                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
            }
            sum += firstArr.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
