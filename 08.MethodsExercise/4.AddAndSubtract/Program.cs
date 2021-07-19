using System;

namespace _05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumFirstTwo(firstNumber, secondNumber);
            int result = SubtractSumFirstTwoAndThirdNumber(sum, thirdNumber);
            Console.WriteLine(result);
        }

        private static int SubtractSumFirstTwoAndThirdNumber(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

        private static int SumFirstTwo(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
