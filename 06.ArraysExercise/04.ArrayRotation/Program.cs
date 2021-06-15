using System;
using System.Linq;

namespace zad4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                string firstElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    string currentElement = array[j];
                    array[j - 1] = currentElement;
                }
                array[array.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}