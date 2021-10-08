using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                char[] result = input.Reverse().ToArray();
                Console.WriteLine($"{input} = {string.Join("",result)}");
            }
        }
    }
}
