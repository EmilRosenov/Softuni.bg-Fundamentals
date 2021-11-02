using System;
using System.Linq;

namespace _05.ProgrammingFundFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] secondInput = Console.ReadLine().Split(">>>").ToArray();

                if (secondInput[0] == "Generate")
                {
                    break;
                }

                string command = secondInput[0];

                if (command == "Contains")
                {
                    string text = secondInput[1];

                    if (input.Contains(text))
                    {
                        Console.WriteLine($"{input} contains {text}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    //Flip >>> Upper >>> 3 >>> 14
                    //Flip >>> Lower >>> 5 >>> 7

                    string upperOrLOwer = secondInput[1];

                    if (upperOrLOwer == "Upper")
                    {
                        int startIndex = int.Parse(secondInput[2]);
                        int endIndex = int.Parse(secondInput[3]);
                        string text = input.Substring(startIndex, endIndex - startIndex);
                        string textToUpper = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                        input = input.Replace(text, textToUpper);

                    }
                    else if (upperOrLOwer == "Lower")
                    {
                        int startIndex = int.Parse(secondInput[2]);
                        int endIndex = int.Parse(secondInput[3]);
                        string text = input.Substring(startIndex, endIndex - startIndex);
                        string textToLower = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        input = input.Replace(text, textToLower);
                    }

                    Console.WriteLine(input);

                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(secondInput[1]);
                    int endIndex = int.Parse(secondInput[2]);

                    string text = input.Substring(startIndex, endIndex - startIndex);
                    input = input.Replace(text, "");

                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
