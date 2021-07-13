using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input =="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                Console.WriteLine(PrintBigger(first,second));
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                Console.WriteLine(PrintBigger(first, second));
            }
            else
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine(PrintBigger(first, second));
            }

        }

        static string PrintBigger(string first, string second)
        {

            int compare = first.CompareTo(second);
            if (compare > 0)
            {
                return first;
            }

            else 
            {
                return second;
            }
        }

        static char PrintBigger(char first, char second)
        {

            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static int PrintBigger(int first, int second)
        {

            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
