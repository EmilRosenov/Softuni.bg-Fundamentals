﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LargestTreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",numbers));

        
        }
    }
}
