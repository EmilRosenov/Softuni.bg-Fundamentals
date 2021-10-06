using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companyAndId =
                                                  new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] inputInfo = input
                                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                string company = inputInfo[0];
                string employeeId = inputInfo[1];

                if (!companyAndId.ContainsKey(company))
                {
                    companyAndId.Add(company, new List<string>());

                    if (!companyAndId[company].Contains(employeeId))
                    {
                        companyAndId[company].Add(employeeId);
                    }
                }

                if (!companyAndId[company].Contains(employeeId))
                {
                    companyAndId[company].Add(employeeId);
                }



                input = Console.ReadLine();
            }

            companyAndId = companyAndId.OrderBy(i => i.Key)
                                       .ToDictionary(i => i.Key, i => i.Value);

            foreach (var item in companyAndId)
            {
                Console.WriteLine(item.Key);

                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
