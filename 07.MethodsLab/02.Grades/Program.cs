using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintResult(grade);
        }

        static void PrintResult(double number)
        {
            string result = "";
            if (number >=2.00 && number <=2.99 )
            {
                result = "Fail";
            }
            if (number >= 3.00 && number <= 3.49)
            {
                result = "Poor";

            }
            if (number >= 3.50 && number <= 4.49)
            {
                result = "Good";

            }
            if (number >= 4.50 && number <= 5.49)
            {
                result = "Very good";

            }
            if (number >= 5.50 && number <= 6.00)
            {
                result = "Excellent";

            }


            Console.WriteLine(result);
        }
    }
}
