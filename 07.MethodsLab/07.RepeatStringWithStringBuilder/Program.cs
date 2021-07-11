using System;
using System.Text;

namespace RepeatStringWithStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());

            string result = PrintInput(input, timesToRepeat);
            Console.WriteLine(result);
        }

        static string PrintInput(string something, int repeat)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < repeat; i++)
            {
                result.Append(something);
                
            }
            return result.ToString();
        }
    }
}
