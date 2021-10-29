using System;
using System.Linq;

namespace _02.ProgFundFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] textInfo = Console.ReadLine().Split(':');
            
            while (textInfo[0] != "Travel")
            {
                if (textInfo[0] =="Travel")
                {
                    Console.WriteLine($"Ready for world tour! Planned stops: {input}");
                    return;
                }
                string command = textInfo[0];
                if (command== "Add Stop")
                {
                    int index = int.Parse(textInfo[1]);
                    string newText =textInfo[2];
                    if (index >= 0 && index <= input.Length)
                    {
                        input = input.Insert(index, newText);
                        
                    }
                    
                    Console.WriteLine(input);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(textInfo[1]);
                    int endIndex = int.Parse(textInfo[2]);

                    if (startIndex >= 0 && endIndex < input.Length)//startIndex < endIndex
                    {
                        input = input.Remove(startIndex, (endIndex - startIndex) + 1);
                        //Console.WriteLine(input);
                    }
                   
                    Console.WriteLine(input);
                }
                else if (command == "Switch")
                {
                    string oldText = textInfo[1];
                    string newText = textInfo[2];

                    if (input.Contains(oldText))
                    {
                        input = input.Replace(oldText, newText);
                        
                    }
                    Console.WriteLine(input);
                }
              
                textInfo = Console.ReadLine().Split(':');
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}

