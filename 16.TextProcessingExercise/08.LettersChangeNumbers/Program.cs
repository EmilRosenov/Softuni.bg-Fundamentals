using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                char firstLetter = current[0];
                char secondLetter = current[current.Length-1];

                double number = double.Parse(current.Substring(1,current.Length-2));

                int indexOfFirstLetter = alphabet.IndexOf(char.ToUpper(firstLetter));
                int indexOfSecondLetter = alphabet.IndexOf(char.ToUpper(secondLetter));


                if (firstLetter >= 65 && firstLetter <=90)
                {
                    number = number / (indexOfFirstLetter + 1);

                }
                else
                {
                    number = number * (indexOfFirstLetter + 1);
                }

                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    number = number - (indexOfSecondLetter + 1);
                }
                else
                {
                    number = number + (indexOfSecondLetter + 1);
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
