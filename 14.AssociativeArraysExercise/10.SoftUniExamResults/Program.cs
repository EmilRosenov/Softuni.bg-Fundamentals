using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, List<string>> cList = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> JavaList = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> AllList = new Dictionary<string, List<string>>();
            int cCounter = 0;
            int javaCounter = 0;
            int otherCounter = 0;
            int numberLAnguages = 0;
            List<string> languageList = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }
                string[] inputInfo = input.Split("-");
                string username = inputInfo[0];
                string language = inputInfo[1];

                if (language == "banned")
                {
                    if (cList.ContainsKey(username))
                    {
                        cList.Remove(username);

                    }

                    if (JavaList.ContainsKey(username))
                    {
                        JavaList.Remove(username);

                    }
                    if (AllList.ContainsKey(username))
                    {
                        AllList.Remove(username);

                    }
                    continue;
                }

                string points = inputInfo[2];

                if (language == "C#")
                {
                    
                    cCounter++;
                    if (!languageList.Contains(language))
                    {
                        languageList.Add(language);
                    }
                    
                    if (!cList.ContainsKey(username))
                    {
                        cList.Add(username, new List<string>());
                        cList[username].Add(language);
                        cList[username].Add(points);

                    }
                    else if (cList.ContainsKey(username) && int.Parse(cList[username][1]) < int.Parse(points))
                    {
                        cList[username][1] = points;
                    }
                    if (!AllList.ContainsKey(username))
                    {
                        AllList.Add(username, new List<string>());
                        AllList[username].Add(language);
                        AllList[username].Add(points);
                    }
                    else if (AllList.ContainsKey(username) && int.Parse(AllList[username][1]) < int.Parse(points))
                    {
                        AllList[username][1] = points;
                    }
                    //else if (AllList.ContainsKey(username) && !AllList[username].Contains(language))
                    //{
                    //    AllList.Add(username, new List<string> { language, points });
                    //
                    //}
                }
                else if (language == "Java")
                {
                    javaCounter++;
                    if (!languageList.Contains(language))
                    {
                        languageList.Add(language);
                    }
                    
                    if (!JavaList.ContainsKey(username))
                    {
                        JavaList.Add(username, new List<string>());
                        JavaList[username].Add(language);
                        JavaList[username].Add(points);

                    }
                    else if (cList.ContainsKey(username) && int.Parse(cList[username][1]) < int.Parse(points))
                    {
                        cList[username][1] = points;
                    }
                    if (!AllList.ContainsKey(username))
                    {
                        AllList.Add(username, new List<string>());
                        AllList[username].Add(language);
                        AllList[username].Add(points);
                    }
                    else if (AllList.ContainsKey(username) && int.Parse(AllList[username][1]) < int.Parse(points))
                    {
                        AllList[username][1] = points;
                    }
                    //else if (AllList.ContainsKey(username) && !AllList[username].Contains(language))
                    //{
                    //    AllList.Add(username, new List<string> { language, points });
                    //    
                    //}
                }
                else
                {

                    otherCounter++;
                    if (!languageList.Contains(language))
                    {
                        languageList.Add(language);
                    }
                    if (!AllList.ContainsKey(username))
                    {
                        AllList.Add(username, new List<string>());
                        AllList[username].Add(language);
                        AllList[username].Add(points);
                    }
                    else if (AllList.ContainsKey(username) && int.Parse(AllList[username][1]) < int.Parse(points))
                    {
                        AllList[username][1] = points;
                    }

                }
            }
            Console.WriteLine("Results:");
            AllList = AllList.OrderByDescending(x => x.Value[1])
                                       .ThenBy(x => x.Key)
                                       .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in AllList.OrderByDescending(x => x.Value[1])
                                           .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value[1]}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var item in languageList.OrderBy(i=>i))
            {
                
                if (item == "C#")
                {
                    Console.WriteLine($"{item} - {cCounter}");
                }
                else if (item == "Java")
                {
                    Console.WriteLine($"{item} - {javaCounter}");
                }
                else 
                {
                    Console.WriteLine($"{item} - {otherCounter}");
                }
            }
                
            //
            //int counterC = 0;
            //int counterJava = 0;
            //
            //foreach (var item in dictionary)
            //{
            //    string lang = item.Value[0];
            //    if (lang == "C#")
            //    {
            //        counterC++;
            //    }
            //    else
            //    {
            //        counterJava++;
            //    }
            //}
            //
            //foreach (var item in dictionary)
            //{
            //    string lang = item.Value[0];
            //
            //    if (lang == "C#")
            //    {
            //        Console.WriteLine($"{item.Value[0]} - {counterC}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item.Value[0]} - {counterJava}");
            //    }
            //
            //}
        }
    }
}
