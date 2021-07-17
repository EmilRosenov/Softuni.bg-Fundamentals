using System;

namespace _03Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (secondChar > firstChar)
            {
                PrintInBetweenChars(secondChar, firstChar);
            }
            else
            {
                PrintReversed(firstChar, secondChar);
            }
            

        }

        private static void PrintReversed(char firstChar, char secondChar)
        {
            char first = firstChar;
            for (int i = secondChar + 1 ; i < firstChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }

        private static void PrintInBetweenChars(char firstChar, char secondChar)
        {
            //char first = firstChar;
            for (int i = secondChar + 1 ; i < firstChar; i++)
            {
                Console.Write((char)i + " ");
            } 
        }
    }
}
