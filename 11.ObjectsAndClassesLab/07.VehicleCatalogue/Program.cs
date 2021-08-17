using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "End")
            {
                string typeOfVehicle = input[0].ToLower();
                string model = input[1];
                string color = input[2].ToLower();
                double horsePower = double.Parse(input[3]);

                

                //ternary operator: condition ? consequent : alternative
                Vehicle currentVehicle = new Vehicle(typeOfVehicle, model,
                                                      color, horsePower);

                catalogue.Add(currentVehicle);


                input = Console.ReadLine().Split().ToArray(); 
            }

            string vehicleBrand = Console.ReadLine();

            while (vehicleBrand != "Close the Catalogue")
            {
                string modelType = vehicleBrand;
                Vehicle printCar = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printCar.ToString());
                vehicleBrand = Console.ReadLine();
            }


            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double avgCarsHp = 0.00;
            double avgTruckHp = 0.00;

            if (onlyCars.Count > 0 )
            {
                avgCarsHp = onlyCars.Sum(x => x.HorsePower) / onlyCars.Count;
                
            }
            if (onlyTrucks.Count > 0)
            {
                avgTruckHp = onlyTrucks.Sum(x => x.HorsePower) / onlyTrucks.Count;

            }

            Console.WriteLine($"Cars have average horsepower of: {avgCarsHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");

        }

        public class Vehicle 
        {
            public Vehicle(string type, string model, string color, double horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Type: {(Type=="car" ? "Car" : "Truck")}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {HorsePower}");


                return sb.ToString().TrimEnd();
            }


        }
    }
}
