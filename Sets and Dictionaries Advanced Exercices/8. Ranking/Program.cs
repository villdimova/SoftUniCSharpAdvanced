using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{

    class Program
    {
        static void Main(string[] args)
        {


            var contests = new Dictionary<string, string>();

            while (true)
            {

                var input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }
                else
                {
                    var contestInfo = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                    var contestName = contestInfo[0];
                    var contestPassword = contestInfo[1];

                    if (!contests.ContainsKey(contestName))
                    {
                        contests.Add(contestName, contestPassword);
                    }
                }
            }

            var students = new Dictionary<string,Dictionary<string, int>>();
            var contestPoints = new Dictionary<string, int>();


            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "end of submissions")
                {
                    break;
                }

                else
                {


                    var internInfo = inputLine.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    var contest = internInfo[0];
                    var password = internInfo[1];
                    var userName = internInfo[2];
                    var points = int.Parse(internInfo[3]);


                    if (contests.ContainsKey(contest))
                    {
                        if (password == contests[contest])
                        {
                            if (!students.ContainsKey(userName))
                            {
                                students.Add(userName, new Dictionary<string, int>());

                            }

                            if (!students[userName].ContainsKey(contest))
                            {
                                students[userName].Add(contest, points);
                            }
                            if (!students[userName].ContainsKey(contest))
                            {
                                students[userName].Add(contest, points);
                            }

                            else
                            {
                                if (students[userName][contest] < points)
                                {
                                    students[userName][contest] = points;
                                }
                            }

                        }
                    }

                }
            }

            int maxPoints = 0;
            string bestIntern = "";

            foreach (var student in students)
            {
                int studentPoints = 0;
                string currentStudent = student.Key;
                foreach (var item in student.Value)
                {
                    studentPoints += item.Value;
                }

                if (studentPoints>maxPoints)
                {
                    maxPoints = studentPoints;
                    bestIntern = currentStudent;

                }
            }

            Console.WriteLine($"Best candidate is {bestIntern} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");


            foreach (var student in students.OrderBy(x=>x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var item in student.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
