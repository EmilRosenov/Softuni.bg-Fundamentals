using System;
using System.Linq;

namespace _01.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                var current = usernames[i];

                if (IsValid(current))
                {
                    Console.WriteLine(current);
                }
            }
        }

        public static bool IsValid(string username)
        {

            return (username.Length >= 3 && username.Length <= 16)
                   && (username.All(c => char.IsLetterOrDigit(c))
                   || (username.Contains("-") || username.Contains("_")));
        }

    }
}
