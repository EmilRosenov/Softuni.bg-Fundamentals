using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peoplesList = new List<Person>();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                string name = command[0];
                string id = command[1];
                int age = int.Parse(command[2]);

                Person currentPerson = new Person(name, id, age);

                peoplesList.Add(currentPerson);

                command = Console.ReadLine().Split().ToArray();
            }


            foreach (var person in peoplesList.OrderBy(x=> x.Age))
            {
                Console.WriteLine(string.Join(Environment.NewLine,person.ToString()));
            }

        }

        public class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {Id} is {Age} years old.";
            }
        }
    }
}
