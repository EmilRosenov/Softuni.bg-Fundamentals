using System;

namespace daysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays =   { "Monday",
                                    "Tuesday",
                                    "Wednesday",
                                    "Thursday",
                                    "Friday",
                                    "Saturday",
                                    "Sunday" };

            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(weekDays[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
                
            }

        }
    }
}
