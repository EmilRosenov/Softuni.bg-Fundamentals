using System;
using System.Linq;


namespace zad9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();


           
            int bestLength = 0;
            int bestSum = 0;
            int bestSequenceIndex = 0;
            int bestStartIndex = 0;
            int currentSequenceIndex = 0;
            int[] bestDna = new int[n];

            while (input != "Clone them!")
            {
                int[] currentArray = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currentSequenceIndex++;

                int bestCurrentLength = 0;
                int currentLength = 1;
                int currentBestStartIndex = 0;
                int currentSum = 0;
               

                for (int i = 0; i < currentArray.Length; i++)
                {
                    int first = currentArray[i];

                    for (int j = i + 1; j < currentArray.Length; j++)
                    {
                        int second = currentArray[j];


                        if (first == second && first != 0)
                        {
                            currentLength++;
                        }
                        else
                        {
                            currentLength = 1;
                            break;
                        }

                        if (currentLength > bestCurrentLength)
                        {
                            bestCurrentLength = currentLength;
                            currentBestStartIndex = i;
                            //bestStartIndex = currentBestStartIndex;
                        }
                       
                    }
                    currentSum += currentArray[i];
                }  
                    

                    if (bestCurrentLength > bestLength)
                    {
                        bestStartIndex = currentBestStartIndex;
                        bestLength = bestCurrentLength;
                        bestSum = currentSum;
                        bestSequenceIndex = currentSequenceIndex;
                        bestDna = currentArray.ToArray();

                    }
                    else if (bestCurrentLength == bestLength)
                    {
                        if (currentBestStartIndex < bestStartIndex)
                        {
                            bestStartIndex = currentBestStartIndex;
                            bestLength = bestCurrentLength;
                            bestSum = currentSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestDna = currentArray.ToArray();
                        }
                    else if (currentBestStartIndex == bestStartIndex)
                    {
                        if (currentSum > bestSum )
                        {
                            bestStartIndex = currentBestStartIndex;
                            bestSum = currentSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestLength = bestCurrentLength;
                            currentArray = bestDna.ToArray();
                        }
                        
                    }
                    
                    
                }

                 input = Console.ReadLine();
                
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
