using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input !="End")
            {
                int index = int.Parse(input);
                
                if (index < 0 || index > sequence.Length -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int temp = 0; 
                for (int i = 0; i < sequence.Length; i++)
                {

                    temp = sequence[index];
                    if (sequence[i] == -1 && i < sequence.Length-1)
                    {

                        if (sequence[i+1] <= temp)// && sequence[i+1] != -1)
                        {
                            sequence[i+1] = sequence[i+1] + temp;

                        }
                        else if (sequence[i+1] >= temp && sequence[i] != -1)
                        {
                            sequence[i] = sequence[i] - temp;
                        }
                        i++;
                    }

                    else if(sequence[i] != -1 && i <= sequence.Length - 1)
                    {
                        if (sequence[i] <= temp)
                        {
                            sequence[i] = sequence[i] + temp;

                        }
                        else if (sequence[i] >= temp)
                        {
                            sequence[i] = sequence[i] - temp;
                        }
                    }

                    sequence[index] = -1;

                    if (i == sequence.Length - 1)
                    {
                        break;
                    }

                }

                input = Console.ReadLine();
            }


            int counter = 0;
            foreach (var item in sequence)
            {
                
                if (item == -1)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" +" " + string.Join(" ", sequence));
        }
    }
}
