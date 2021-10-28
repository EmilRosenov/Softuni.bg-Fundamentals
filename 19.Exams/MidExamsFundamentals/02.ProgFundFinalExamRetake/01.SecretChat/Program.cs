using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();
            while (input!="Reveal")
            {
                string[] cmdAr = input.Split(":|:").ToArray();
                string command = cmdAr[0];

                if (command== "InsertSpace")
                {
                    int index = int.Parse(cmdAr[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = cmdAr[1];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, "");
                        
                        StringBuilder sb = new StringBuilder();

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            sb.Append(substring[i]);
                        }

                        string reversed = sb.ToString();
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append(message);
                        sb2.Append(reversed);
                        message = sb2.ToString();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = cmdAr[1];
                    string replacement = cmdAr[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
