using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Object
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string pattern = @"(#|\|)((\s*[A-z]{3,}\s*[A-z]+\s*))\1((([0]{1}[1-9]{1}|[1-2]{1}[0-9]{1}|[3]{1}[0-1]{1})))\/((([0]{1}[1-9]{1}|[1-2]{1}[0-2]{1}))\/(([0-9]{1}[0-9]{1})))\1(\d+)\1";
            
            string foodPattern = @"(\s*[A-z]{3,}\s*[A-z]+\s*)";
            string yearPattern = @"(([0]{1}[1-9]{1}|[1-2]{1}[0-9]{1}|[3]{1}[0-1]{1}))\/(([0]{1}[1-9]{1}|[1-2]{1}[0-2]{1}))\/(([0-9]{1}[0-9]{1}))";
            string caloriesPattern = @"(#|\|)\d{1,5}(#|\|)";

            
            List<Object> objectList = new List<Object>();
            

            var matches = Regex.Matches(input, pattern);
            int totalSum = 0;

            foreach (Match item in matches)
            {
                //Console.WriteLine(item);
                Object subject = new Object();
                var foodMatches = Regex.Matches(item.Value, foodPattern);
                foreach (Match food in foodMatches)
                {

                    subject.Name = food.Value;
                    objectList.Add(subject);
                    
                    //Console.WriteLine(food);
                    
                }

                var dateMatches = Regex.Matches(item.Value, yearPattern);
                foreach (Match date in dateMatches)
                {
                    subject.Date = date.Value;
                    //objectList.Add(subject);
                }

                
                var caloriesMatches = Regex.Matches(item.Value, caloriesPattern);

                foreach (Match number in caloriesMatches)
                {

                    if (number.
                        Value.Contains('#'))
                    {

                        string text = number.Value.Trim('#');
                        int caloriesNumber = int.Parse(text);
                        subject.Calories = caloriesNumber;
                        totalSum += caloriesNumber;
                        //caloriesPattern = caloriesPattern.TrimEnd('#');


                    }
                    else if (number.
                        Value.Contains('|'))
                    {
                        string text = number.Value.Trim('|');
                        int caloriesNumber = int.Parse(text);
                        subject.Calories = caloriesNumber;
                        totalSum += caloriesNumber;
                        //caloriesPattern = caloriesPattern.Trim('|');
                        //caloriesPattern = caloriesPattern.TrimEnd('|');
                    }
                    
                }
                //objectList.Add(subject);
            }

            int result = totalSum / 2000;
            Console.WriteLine($"You have food to last you for: {result} days!");
            foreach (var item in objectList)
            {
                Console.WriteLine($"Item: {item.Name}, Best before: { item.Date}, Nutrition: {item.Calories}");
            }
            
        }
    }
}
