using System;
//using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.Words = Console.ReadLine().Split();
            randomizer.Randomise();
            randomizer.PrintWords();
        }
    }

    public class StringRandomizer
    {
        public string[] Words;

        public void Randomise()
        {
            Random rand = new Random();

            for (int i = 0; i < this.Words.Length; i++)
            {
                int generator = rand.Next(0, this.Words.Length);

                string temp = this.Words[i];
                this.Words[i] = this.Words[generator];
                this.Words[generator] = temp;
            }

        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.Words));
        }
    }
}
