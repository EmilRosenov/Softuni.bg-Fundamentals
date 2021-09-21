using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsSecondTime
{
    partial class StudentsSecondTime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);
                studentsList.Add(student);

            }

            studentsList = studentsList.OrderByDescending(x => x.Grade).ToList();
            foreach (var item in studentsList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }

        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }


        }
    }
}

