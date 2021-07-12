using System;

namespace MathPower2
{
    class MathPower2
    {
        static void Main(string[] args)
        { 

            Console.WriteLine(PrintResult(double.Parse(Console.ReadLine()),
                        double.Parse(Console.ReadLine())));
        }

        static double PrintResult(double x, double y)
        {
            double result = Math.Pow(x, y);
            return result;
        }
    }
}
