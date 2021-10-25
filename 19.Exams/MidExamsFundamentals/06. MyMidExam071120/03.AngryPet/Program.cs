using System;
using System.Linq;

namespace _03.AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToArray();

            int indexOfEntryPoint = int.Parse(Console.ReadLine());

            string itemsType = Console.ReadLine();
            string typeOfPriceRating = Console.ReadLine();

            int sumOfPriceRatingsLeft = 0;
            int sumOfPriceRatingsRight = 0;

            if (itemsType=="cheap")
            {
                for (int i = 0; i < indexOfEntryPoint; i++)
                {
                    if (typeOfPriceRating=="positive")
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] > priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsLeft += priceRatings[i];
                        }
                        
                    }
                    else if (typeOfPriceRating == "negative")
                    {
                        if (priceRatings[i]< 0 && priceRatings[i] < priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsLeft += priceRatings[i];
                        }
                        
                    }
                    else
                    {
                        sumOfPriceRatingsLeft += priceRatings[i];
                    }
                    
                }

                for (int i = indexOfEntryPoint+1; i < priceRatings.Length; i++)
                {
                    if (typeOfPriceRating == "positive")
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsRight += priceRatings[i];
                        }

                    }
                    else if (typeOfPriceRating == "negative")
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsRight += priceRatings[i];
                        }

                    }
                    else
                    {
                        sumOfPriceRatingsRight += priceRatings[i];
                    }

                }
            }
            else if (itemsType == "expensive")
            {
                for (int i = 0; i < indexOfEntryPoint; i++)
                {
                    if (typeOfPriceRating=="positive")
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsLeft += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRating == "negative")
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsLeft += priceRatings[i];
                        }
                    }
                    else
                    {
                        sumOfPriceRatingsLeft += priceRatings[i];
                    }
                    
                }

                for (int i = indexOfEntryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (typeOfPriceRating == "positive")
                    {
                        if (priceRatings[i] >= 0 && priceRatings[i] >= priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsRight += priceRatings[i];
                        }
                    }
                    else if (typeOfPriceRating == "negative")
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[indexOfEntryPoint])
                        {
                            sumOfPriceRatingsRight += priceRatings[i];
                        }
                    }
                    else
                    {
                        sumOfPriceRatingsRight += priceRatings[i];
                    }

                }
            }

            string position = " ";

            if (sumOfPriceRatingsLeft>=sumOfPriceRatingsRight)
            {
                position = "Left";

                Console.WriteLine($"{position} - {sumOfPriceRatingsLeft}");
            }
            else
            {
                position = "Right";

                Console.WriteLine($"{position} - {sumOfPriceRatingsRight}");
            }

        }
    }
}
