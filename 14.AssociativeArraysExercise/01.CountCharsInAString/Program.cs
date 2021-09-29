using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseAssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> text = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (text.ContainsKey(letter))
                    {
                        text[letter]++;
                    }
                    else
                    {
                        text.Add(letter, 1);
                    }
                }
            }

            foreach (var currentChar in text)
            {
                Console.WriteLine($"{currentChar.Key} -> {currentChar.Value}");
            }
        }
    }
}
