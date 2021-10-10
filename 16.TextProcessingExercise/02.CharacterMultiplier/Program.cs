using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string stringOne = input[0];
            string stringTwo = input[1];

            Console.WriteLine(Printsum(stringOne, stringTwo));

            //Printsum();
        }

        public static int Printsum(string first, string second)
        {
            int totalSum = 0;
            bool AreNotEqual = false;

            while (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                   int sum =  first[i] * second[i];
                   totalSum += sum;

                    if (i >= first.Length-1)
                    {
                        AreNotEqual = true;
                        break;
                    }
                }

                if (AreNotEqual)
                {
                    break;
                }
            }



            return totalSum;
        }
    }
}
