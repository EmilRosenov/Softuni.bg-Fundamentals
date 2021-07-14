using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }

        static int GetMultipleOfEvenAndOdds(int number)
        { 
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;

            while(number > 0)
            {
                int lastnumber = number % 10;

                if(lastnumber % 2 ==0)
                {
                    sumEven += lastnumber;
                }

                number = number / 10;
            }
            return sumEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;

            while (number > 0)
            {
                int lastnumber = number % 10;

                if (lastnumber % 2 != 0)
                {
                    sumOdd += lastnumber;
                }

                number = number / 10;
            }
            return sumOdd;
        }
    }
}
