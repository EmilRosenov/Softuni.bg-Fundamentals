using System;
using System.Linq;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);
        }

        static void Print(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                bool isDivisivbleBy8 = IsDivisivbleBy8(i);
                bool doesItConsistsAtleastOneOdd = DoesItConsistsAtleastOneOdd(i);

                if (isDivisivbleBy8 == true &&
                    doesItConsistsAtleastOneOdd==true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDivisivbleBy8(int i)
        {
           
            int sum = 0;
            while (i>0)
            {
                int lastDigit = i % 10;
                sum += lastDigit;
                i /= 10;
            }
            if (sum % 8 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool DoesItConsistsAtleastOneOdd(int i)
        {
            while (i>0)
            {
                int lastdigit = i % 10;

                if (lastdigit % 2 != 0 )
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }
    }
}
