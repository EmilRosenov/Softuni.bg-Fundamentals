using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            //{car}|{mileage}|{fuel}
            int n = int.Parse(Console.ReadLine());
            var carDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split("|").ToArray();
                string car = inputInfo[0];
                int startingMileage = int.Parse(inputInfo[1]);
                int startingFuel = int.Parse(inputInfo[2]);

                carDict.Add(car, new Dictionary<string, int>());
                carDict[car].Add("Mileage", startingMileage);
                carDict[car].Add("Fuel", startingFuel);
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] inputInfo = input.Split(" : ").ToArray();
                string command = inputInfo[0];
                string car = inputInfo[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(inputInfo[2]);
                    int fuelNeeded = int.Parse(inputInfo[3]);

                    if (carDict[car]["Fuel"] >= fuelNeeded)
                    {
                        carDict[car]["Mileage"] += distance;
                        carDict[car]["Fuel"] -= fuelNeeded;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                        if (carDict[car]["Mileage"] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carDict.Remove(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command == "Refuel")
                {
                    int amountFuelToRefill = int.Parse(inputInfo[2]);
                    int maxAmountFuel = 75;


                    if (carDict[car]["Fuel"] < maxAmountFuel)
                    {
                        int fuelNeededToFull = maxAmountFuel - carDict[car]["Fuel"];
                        carDict[car]["Fuel"] += amountFuelToRefill;
                        if (carDict[car]["Fuel"] > maxAmountFuel)
                        {
                            carDict[car]["Fuel"] = maxAmountFuel;
                            Console.WriteLine($"{car} refueled with {fuelNeededToFull} liters");

                        }
                        else if (carDict[car]["Fuel"] <= maxAmountFuel)
                        {
                            Console.WriteLine($"{car} refueled with {amountFuelToRefill} liters");
                        }
                    }
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(inputInfo[2]);
                    carDict[car]["Mileage"] -= kilometers;
                    if (carDict[car]["Mileage"] >= 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carDict[car]["Mileage"] = 10000;
                    }
                }

                input = Console.ReadLine();
            }

            //sorted by their mileage in decscending order,
            // then by their name in ascending order,

            carDict = carDict
                            .OrderByDescending(x => x.Value["Mileage"])
                            .ThenBy(y => y.Key)
                            .ToDictionary(x => x.Key, y => y.Value);
            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."

            var carsList = new Dictionary<string, int>();
            foreach (var car in carDict.Keys)
            {
                if (!carsList.ContainsKey(car))
                {
                    carsList.Add(car, carDict[car]["Mileage"]);
                }
            }
            carsList = carsList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            List<string> newCarList = new List<string>();

            foreach (var item in carDict.Keys)
            {
                if (!newCarList.Contains(item))
                {
                    newCarList.Add(item);
                }
            }

            int counter = 0;
            string carToPrint = "";


            foreach (var item in carDict.Values)
            {
                carToPrint = newCarList[counter];
                int miles = 0;
                int fuel = 0;
                //string carname = car.Key;
                //Console.WriteLine(car);

                miles = item["Mileage"];
                fuel = item["Fuel"];
                Console.WriteLine($"{carToPrint} -> Mileage: {miles} kms, Fuel in the tank: {fuel} lt.");
                counter++;
                if (counter == newCarList.Count)
                {
                    break;
                }
            }

        }
    }
}
