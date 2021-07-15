using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintResult(x, action, y));
        }

        static double PrintResult(double x, string action, double y)
        {
            double result = 0;
            if (action=="/")
            {
                result = x / y;
            }
            else if (action == "*")
            {
                result = x * y;
            }
            else if (action == "+")
            {
                result = x + y;
            }
            else if (action == "-")
            {
                result = x - y;
            }

            return result;
        }

    }
}
