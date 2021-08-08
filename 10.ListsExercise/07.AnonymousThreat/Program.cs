using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            string[] command = Console.ReadLine()
                                      .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            //Ivo Johny Tony Bony Mony

            //abcd efgh ijkl mnop qrst uvwx yz

            
            while (command[0].ToUpper() !="3:1")
            {
                string action = command[0].ToUpper();

                if (action == "MERGE")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    string concatData = string.Empty;

                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex <= input.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }

                    if (endIndex > input.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= input.Count - 1)
                        {
                            endIndex = input.Count - 1;
                        }
                    }


                    if ((startIndex >= 0 && startIndex <= input.Count - 1)
                        && (endIndex >= 0 && endIndex <= input.Count - 1))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatData += input[i];
                        }

                        input.RemoveRange(startIndex, endIndex - startIndex + 1);
                        input.Insert(startIndex, concatData);
                    }


                }
                else if (action == "DIVIDE")  //abcdef, ghi, jkl    divide 0 3
                {

                    int index = int.Parse(command[1]);
                    int partititons = int.Parse(command[2]);


                    if (index >=0 && index <= input.Count-1)
                    { 
                        string word = input[index];
                        int wordCount = word.Length;

                        int newWordLenghtAfterPartition = wordCount / partititons;
                    

                        List<string> result = new List<string>();

                        int startIndex = 0;

                        for (int i = 0; i < partititons; i++)  //abcd divide 0 3
                        {

                        if (i == partititons-1)
                        {
                            result.Add(word.Substring(startIndex, wordCount - startIndex));
                        }
                        else
                        {
                            result.Add(word.Substring(startIndex, newWordLenghtAfterPartition));
                           
                        }
                        startIndex += newWordLenghtAfterPartition;
                        }

                    input.RemoveAt(index);
                    input.InsertRange(index, result);
                    }

                }   
                command = command = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            }

            Console.WriteLine(string.Join(' ',input));
        }
    }
}
