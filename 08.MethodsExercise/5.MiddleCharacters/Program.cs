using System;

namespace _06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetMiddleFromAnEvenINput(input);
                Console.WriteLine(output);
            }
            else
            {
                string outputFromOdd = GetMiddleFromOddInput(input);
                Console.WriteLine(outputFromOdd);
            }
        }

        private static string GetMiddleFromOddInput(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleFromAnEvenINput(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
