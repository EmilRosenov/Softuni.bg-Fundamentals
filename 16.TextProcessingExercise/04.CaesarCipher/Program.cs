using System;
using System.Linq;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.All(c => char.GetNumericValue(c) + 3).ToString();
            
        }
    }
}
