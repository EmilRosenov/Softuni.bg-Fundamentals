using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (input == "coffee")
            {
                price = PrintCoffee(quantity, 1.50);
            }
            else if (input == "water")
            {
                price = PrintWater(quantity, 1.00);
            }
            else if (input == "coke")
            {
                price = PrintCoke(quantity, 1.40);
            }
            else if (input == "snacks")
            {
                price = PrintSnacks(quantity, 2.00);
            }
            Console.WriteLine($"{price:f2}");
        }

        private static double PrintWater(double quantity, double price)
        {
            return quantity * price;
        }

        private static double PrintSnacks(double quantity, double price)
        {
            return quantity * price;
        }
        private static double PrintCoke(double quantity, double price)
        {
            return quantity* price;
        }
        
        private static double PrintCoffee(double quantity, double price)
        {
            return quantity * price;
        }
    }

}