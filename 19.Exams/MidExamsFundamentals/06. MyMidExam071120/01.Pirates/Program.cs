using System;

namespace _03.MidExam071120
{
    class Program
    {
        static void Main(string[] args)
        {
            int plunderDaysTotal = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int day = 1; day <= plunderDaysTotal; day++)
            {
                double thirdDaysPlunder = 0;
                if (day % 3 == 0)
                {
                    thirdDaysPlunder = 1.5* dailyPlunder;
                    totalPlunder += thirdDaysPlunder;
                }
                else if (day % 5 == 0)
                {
                    totalPlunder += dailyPlunder;
                    totalPlunder *= 0.7;
                }
                else
                {
                    totalPlunder += dailyPlunder;
                }
            }

            if (totalPlunder > expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentageCollected = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentageCollected:f2}% of the plunder.");
            }
        }
    }
}
