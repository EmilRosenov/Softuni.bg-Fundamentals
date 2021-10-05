using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentInfo =
                                                new Dictionary<string, List<double>>();


            Dictionary<string, double> filtered = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string studentsName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());


                if (!studentInfo.ContainsKey(studentsName))
                {
                    studentInfo.Add(studentsName, new List<double>());
                    
                }
                studentInfo[studentsName].Add(grade);
            }

            double sum = 0;
            double average = 0;
            
            foreach (var item in studentInfo)
            {
                sum = item.Value.Sum();
                average = sum / item.Value.Count;
                if (average >= 4.5)

                    if (!filtered.ContainsKey(item.Key))
                    {
                        filtered.Add(item.Key, average);
                        
                    }
            }

            filtered = filtered.OrderByDescending(f => f.Value)
                                           .ToDictionary(f => f.Key, f => f.Value);
            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Key} -> {person.Value:f2}");
            }
        }
    }
}
