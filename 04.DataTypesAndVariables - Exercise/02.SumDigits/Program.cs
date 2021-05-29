﻿using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyOfNum = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
