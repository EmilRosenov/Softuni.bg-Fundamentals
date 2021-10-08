using System;

namespace _02.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                           .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (string word in arr)
            {
                int wordLenght = word.Length;

                for (int i = 0; i < wordLenght; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
