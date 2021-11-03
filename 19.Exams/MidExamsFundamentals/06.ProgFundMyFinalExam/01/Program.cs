using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string recievedLetters = Console.ReadLine();

            string[] inputArgs = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            List<string> wordsCollection = new List<string>();
            List<char> lettersCollection = new List<char>();

            while (inputArgs[0] != "Play")
            {


                string command = inputArgs[0];

                if (command == "Move")
                {
                    int index = int.Parse(inputArgs[1]);

                    if (index < 0 || index > recievedLetters.Length - 1)
                    {
                        inputArgs = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                        continue;
                    }

                    string substring = recievedLetters.Substring(index, 1);
                    recievedLetters = recievedLetters.Remove(index, 1);
                    recievedLetters = recievedLetters.Insert(recievedLetters.Length, substring);

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputArgs[2]);
                    recievedLetters = recievedLetters.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string text = inputArgs[1];
                    string newText = "";
                    if (recievedLetters.Contains(text))
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            recievedLetters = recievedLetters.Replace(text, "");
                        }
                        for (int i = text.Length - 1; i >= 0; i--)
                        {
                            newText += text[i];
                        }
                        //text = text.Reverse().ToCharArray();
                        recievedLetters = recievedLetters.Insert(recievedLetters.Length, newText);
                        // Console.WriteLine();
                    }
                }
                else if (command == "Exchange")
                {
                    string substring = inputArgs[2];
                    int substringLenght = substring.Length;
                    string textToBeReplaced = recievedLetters.Substring(0, substringLenght);
                    recievedLetters = recievedLetters.Replace(textToBeReplaced, substring);
                    
                    
                    if (recievedLetters.Contains(" ")) ;
                    {
                        string[] newRecieved = recievedLetters.Split(" ");
                        foreach (var word in newRecieved)
                        {
                            wordsCollection.Add(word);
                        }
                    }

                    inputArgs = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                    continue;

                }
                else if (command == "Pass")
                {
                    if (recievedLetters.Contains(" "))
                    {
                        int indexOfSpace = recievedLetters.IndexOf(' ');
                        StringBuilder sb = new StringBuilder();
                        string substring = recievedLetters.Substring(0, indexOfSpace);
                        string secondSubstring = recievedLetters.Substring(indexOfSpace + 1, (recievedLetters.Length - 1) - (indexOfSpace));
                        wordsCollection.Add(substring);
                        wordsCollection.Add(secondSubstring);
                        sb.Append(substring);
                        sb.Append(" ");
                        sb.Append(secondSubstring);
                        recievedLetters = sb.ToString();
                        
                    }
                }
                else
                {
                    inputArgs = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                    continue;
                }
               
                inputArgs = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
            }
            int counter = 0;
            foreach (var item in recievedLetters)
            {
                if (item==' ')
                {
                    counter++;
                }
            }
            if (recievedLetters.Contains(" ") && counter > 1)
            {
                StringBuilder sb = new StringBuilder();
                //sb.Append("You are playing with the word ");
                for (int i = 0; i < recievedLetters.Length; i++)
                {
                    sb.Append(recievedLetters[i]);
                    sb.Append(" ");

                }
                
                Console.WriteLine(sb.ToString());
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You are playing with the word ");
                sb.Append($"{wordsCollection[0]}.");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
