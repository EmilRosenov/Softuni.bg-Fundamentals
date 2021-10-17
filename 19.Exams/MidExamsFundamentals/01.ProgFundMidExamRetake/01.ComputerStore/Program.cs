using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalPrice = 0;
            bool isSpecial = false;
            bool isRegular = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special")
                {
                    isSpecial = true;
                    break;
                }
                else if (input == "regular")
                {
                    isRegular = true;
                    break;
                }


                double price = double.Parse(input);

                if (price >= 0)
                {
                    totalPrice += price;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }

           
            double tax = 0;
            tax = totalPrice *0.2;
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }

            if (isRegular && totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice + tax:f2}$");
            }
            else if (isSpecial && totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPrice + tax)*0.9:f2}$");
            }
            
        }
    }
}
