using System;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            //a, e, i, o, u, y

            PrintVowels(input);

        }

        private static void PrintVowels(string input)
        {

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a')
                {
                    count++;
                }
                else if (currentChar == 'e')
                {
                    count++;
                }
                else if (currentChar == 'i')
                {
                    count++;
                }
                else if (currentChar == 'o')
                {
                    count++;
                }
                else if (currentChar == 'u')
                {
                    count++;
                }
                else if (currentChar == 'y')
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
