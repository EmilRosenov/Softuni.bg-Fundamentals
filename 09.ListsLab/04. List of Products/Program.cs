using System;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> vegetables = new List<string> (n);

            for (int i = 0; i < n; i++)
            {
                string currenetProduct = Console.ReadLine();
                vegetables.Add(currenetProduct);
                
            }

            vegetables.Sort();

            for (int i = 0; i < vegetables.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{vegetables[i]}");
            }
            


        }
    }
}
