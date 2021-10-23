using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firtsPersonEfficiencyPH = double.Parse(Console.ReadLine());
            double secondPersonEfficiencyPH = double.Parse(Console.ReadLine());
            double thirdPersonEfficiencyPH = double.Parse(Console.ReadLine());
            double peopleCount = double.Parse(Console.ReadLine());



            double totalEmployeesEfficiencyPH = 0;
            double timeNeeded = 0;

            
            while (peopleCount > 0)
            {
                for (int i = 0; i <= 24; i++)
                {
                    totalEmployeesEfficiencyPH = firtsPersonEfficiencyPH
                                           + secondPersonEfficiencyPH
                                           + thirdPersonEfficiencyPH;

                    peopleCount -= totalEmployeesEfficiencyPH;

                    if (i % 4 == 0)
                    {
                        i += 1;
                    }


                    timeNeeded = i;
                    if (peopleCount <= 0)
                    {
                        break;
                    }
                }
            }

           
            Console.WriteLine($"Time needed: {Math.Round(timeNeeded)}h.");
        }
    }
}
