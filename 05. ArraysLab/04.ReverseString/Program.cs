using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine()
                .Split()
                .Reverse())) ;

            //Greshno Uprajnenie po-dolu;

            //string line = Console.ReadLine();
            //string[] newLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //
            //for (int i = 0; i < line.Length; i++)
            //{
            //    
            //    
            //}
            //newLine[i] = string.Join(" ", line.Reverse());
            //Console.WriteLine(newLine);

        }
    }
}
