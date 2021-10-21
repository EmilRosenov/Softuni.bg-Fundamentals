using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int counterWonBattles = 0;
            bool gameFinished = false;
            int counter = 0;

            while (true)
            {

                string distance = Console.ReadLine();

                if (distance == "End of battle")
                {
                    gameFinished = true;
                    break;
                }
                
                if (int.Parse(distance) > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy");
                    return;
                }

                counter++;

                if (counter % 3 == 0)
                {
                    counterWonBattles++;
                    initialEnergy = (initialEnergy - int.Parse(distance)) + counterWonBattles;

                }
                else
                {
                    initialEnergy -= int.Parse(distance);
                    counterWonBattles++;
                }

                if (initialEnergy <= 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterWonBattles} won battles and 0 energy");
                    return;
                }

            }
            if (gameFinished)
            {
                if (initialEnergy>0)
                {
                    Console.WriteLine($"Won battles: {counterWonBattles}. Energy left: {initialEnergy}");
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterWonBattles} won battles and 0 energy");
                }
               
               
            }
        }
    }
}
