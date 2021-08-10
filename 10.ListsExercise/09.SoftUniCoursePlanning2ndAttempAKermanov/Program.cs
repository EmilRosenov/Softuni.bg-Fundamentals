using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning2ndAttempAKermanov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                                           .Split(", ")
                                           .ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] commands = input.Split(":").ToArray();

                string action = commands[0];
                string lessonTitle = commands[1];

                if (action == "Add")
                {
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                    }
                }

                else if (action == "Insert")
                {
                    int index = int.Parse(commands[2]);

                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }

                else if (action == "Remove")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        int indexOfFirstLesson = schedule.IndexOf(lessonTitle);

                        if (schedule.Contains($"{lessonTitle}-Exercise"))
                        {
                            int indexOfExercise = indexOfFirstLesson + 1;
                            string exercise = schedule[indexOfExercise];

                            if (indexOfExercise != -1 && exercise == $"{lessonTitle}-Exercise")
                            {
                                schedule.Remove(exercise);
                            }
                        }

                        if (indexOfFirstLesson != -1)
                        {
                            schedule.Remove(lessonTitle);
                        }


                    }

                }

                else if (action == "Swap")
                {
                    string secondLessonTitle = commands[2];

                    int indexOfLessonTitle = schedule.IndexOf(lessonTitle);
                    int indexOfSecondLessonTitle = schedule.IndexOf(secondLessonTitle);

                    if (schedule.Contains(lessonTitle) && schedule.Contains(secondLessonTitle))
                    {
                        if (indexOfLessonTitle != -1 && indexOfSecondLessonTitle != -1)
                        //&& schedule[indexOfLessonTitle+1] != $"{lessonTitle}-Exercise" 
                        //&& schedule[indexOfSecondLessonTitle + 1] != $"{secondLessonTitle}-Exercise")

                        {
                            schedule[indexOfLessonTitle] = secondLessonTitle;
                            schedule[indexOfSecondLessonTitle] = lessonTitle;
                        }

                        if (schedule.Contains($"{lessonTitle}-Exercise"))
                        {
                            int lessonExerciseIndex = schedule.IndexOf($"{lessonTitle}-Exercise");
                            schedule.RemoveAt(lessonExerciseIndex);
                            indexOfLessonTitle = schedule.IndexOf(lessonTitle);
                            schedule.Insert(indexOfLessonTitle + 1, $"{lessonTitle}-Exercise");
                        }
                        if (schedule.Contains($"{secondLessonTitle}-Exercise"))
                        {
                            int secondLessonExerciseIndex = schedule.IndexOf($"{secondLessonTitle}-Exercise");
                            schedule.RemoveAt(secondLessonExerciseIndex);
                            indexOfSecondLessonTitle = schedule.IndexOf(secondLessonTitle);
                            schedule.Insert(indexOfSecondLessonTitle + 1, $"{secondLessonTitle}-Exercise");
                        }

                    }

                }
                else if (action == "Exercise")
                {
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add($"{lessonTitle}-Exercise");
                    }
                    else
                    {
                        int indexOfLessonTitle = schedule.IndexOf(lessonTitle);

                        if (indexOfLessonTitle != -1)
                        {
                            schedule.Insert(indexOfLessonTitle + 1, $"{lessonTitle}-Exercise");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
