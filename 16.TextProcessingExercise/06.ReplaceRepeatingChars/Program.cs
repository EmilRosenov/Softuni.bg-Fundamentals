using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 0;
            string text = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                for (int j = i+1; j < input.Length; j++)
                {
                    char nextChar = input[j];

                    if (currentChar != nextChar)
                    {
                        text += currentChar;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                    
                   //else
                   //{
                   //    text += nextChar;
                   //
                   //
                   //}
                }
                input = input.Remove(i, counter);
                //string substring = input.Substring(i, counter);
                //input = input.Remove(i + 1, counter);
                //
                //text += substring[0];


                //if (text[i] == text[i+1])
                //{
                //    continue;
                //}
                //else
                //{
                //    text += substring[0];
                //}

                counter = 1;
            }
            Console.WriteLine(text);
        }
    }
}
