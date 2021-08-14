using System;
using System.Collections.Generic;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Student> studentList = new List<Student>();

            while (command[0] != "end")
            {

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string town = command[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = town;

                
                studentList.Add(student);



                command = Console.ReadLine().Split();
            }

            string city = Console.ReadLine();

            foreach (Student student in studentList)
            {
                if (student.City == city)
                {
                    student.PrintSudent(student);
                }
            }
        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;


        public void PrintSudent(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }
}
