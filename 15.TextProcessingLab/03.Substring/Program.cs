using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToBeRemoved = Console.ReadLine();
            string text = Console.ReadLine();

            int indexOfWordToBeRemoved = text.IndexOf(wordToBeRemoved);

            while (indexOfWordToBeRemoved != -1)
            {
                text = text.Remove(indexOfWordToBeRemoved, wordToBeRemoved.Length);

                indexOfWordToBeRemoved = text.IndexOf(wordToBeRemoved);
            }


            Console.WriteLine(text);
        }
    }
}
