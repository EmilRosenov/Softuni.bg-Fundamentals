using System;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] placeAndHearts = line.Split("@",StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse).ToArray();
            //Console.WriteLine(string.Join(",",placeNumbers));

            string[] input = Console.ReadLine().Split();
            int position = 0;
            int counter = 0;

            while (input[0]!= "Love")
            {
                
                if (input[0] == "Jump")
                {
                   
                    for (int i = 0; i < placeAndHearts.Length; i++)
                    {
                        if (input[0] == "Love!")
                        {
                            break;
                        }

                        int lenght = int.Parse(input[1]);
                        int startIndex = i;

                        if (placeAndHearts[startIndex + lenght] > 0)
                        {
                            placeAndHearts[startIndex + lenght] -= 2;
                        }
                        else
                        {
                            if (placeAndHearts[startIndex + 1 + lenght] > 0)
                            {
                                placeAndHearts[startIndex + 1 + lenght] -= 2;
                            }

                        }

                        if (placeAndHearts[startIndex + lenght] == 0 && counter > 0)
                        {
                            Console.WriteLine($"Place {startIndex + lenght} has already had Valentine's day.");

                        }

                        counter = 0;

                        if (startIndex + lenght > placeAndHearts.Length - 1)
                        {
                            startIndex = 0;
                            lenght = 0;
                        }


                        if (placeAndHearts[startIndex + lenght] == 0) 
                        {
  
                            counter++;
                        }

                        if (lenght > placeAndHearts[startIndex + lenght])
                        {
                            input = Console.ReadLine().Split();
                            continue;
                        }
                       
                        if (placeAndHearts[startIndex + lenght] ==0 && counter == 0 )
                        {
                            Console.WriteLine($"Place {startIndex + lenght} has Valentine's day.");
                            counter++;
                        }

                        
                        position = startIndex + lenght;
                        
                        input = Console.ReadLine().Split();
                    }
                    
                }

                if(input[0]=="Love!")
                {
                    break;
                }
                //
                //input = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {position}.");
            int fails = 0;
            foreach (var place in placeAndHearts)
            {
                if (place > 0)
                {
                    fails++;
                }
            }

            Console.WriteLine($"Cupid has failed {fails} places.");
        }
    }
}
