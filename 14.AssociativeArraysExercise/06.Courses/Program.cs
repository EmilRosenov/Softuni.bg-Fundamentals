using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfoLIst = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();

                
                if (input == "end")
                {
                    break;
                }

                string[] inputInfo = input.Split(" : ");
                string course = inputInfo[0];
                string student = inputInfo[1];

                if (!courseInfoLIst.ContainsKey(course))
                {
                    courseInfoLIst.Add(course, new List<string>());
                }

                courseInfoLIst[course].Add(student);
            }


            //Dictionary<string, List<string>> filtered = CourseInfoList
            //                                        .OrderByDescending(x => x.Value.Count)
            //                                        .ThenBy(x => x.Key)
            //                                        .ToDictionary(a=>a.Key, a=>a.Value);
            foreach (var courseName in courseInfoLIst.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");

                foreach (var student in courseName.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}
