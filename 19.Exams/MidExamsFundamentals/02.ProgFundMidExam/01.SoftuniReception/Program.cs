using System;

namespace _02.ProgrammingFundamentalsMidExam
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
            int hours = 0;


            while (peopleCount > 0)
            {
                hours++;
                
                    totalEmployeesEfficiencyPH = firtsPersonEfficiencyPH
                                           + secondPersonEfficiencyPH
                                           + thirdPersonEfficiencyPH;

                    peopleCount -= totalEmployeesEfficiencyPH;

                    if (hours % 4 == 0)
                    {
                        hours += 1;
                    }


                    timeNeeded = hours;

                    if (peopleCount <= 0)
                    {
                        break;
                    }
                
            }


            Console.WriteLine($"Time needed: {Math.Round(timeNeeded)}h.");
        }
    }
}
        
