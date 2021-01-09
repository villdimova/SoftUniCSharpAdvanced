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
                    var contestInfo = input.Split(":");
                    var contestName = contestInfo[0];
                    var contestPassword = contestInfo[1];

                    if (!contests.ContainsKey(contestName))
                    {
                        contests.Add(contestName, contestPassword);
                    }
                }
            }

            var interns = new Dictionary<string, List<Dictionary<string,int>>>();
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
                    var nameContest = internInfo[0];
                    var password = internInfo[1];
                    var userName = internInfo[2];
                    var points = int.Parse(internInfo[3]);

                    
                    if (contests.ContainsKey(nameContest))
                    {
                        if (password == contests[nameContest])
                        {
                            if (!contestPoints.ContainsKey(nameContest))
                            {
                                contestPoints.Add(nameContest,points);
                                if (!interns.ContainsKey(userName))
                                {
                                    interns.Add(userName, new List<Dictionary<string, int>>());

                                    interns[userName].Add(contestPoints);
                                }
                            }

                            else
                            {
                                if (contestPoints[nameContest]<points)
                                {
                                    contestPoints[nameContest] = points;
                                }
                            }
                            
                            
                            
                        }
                    }

                }
            }

            

            int maxPoints = 0;
            string bestIntern = "";
            foreach (var intern in interns)
            {
                int internResult = 0;
                string currentIntern = intern.Key;
                foreach (var contest in intern.Value)
                {
                    foreach (var result in contest)
                    {
                        
                            internResult += result.Value;
                        
                    }

                    if (internResult>maxPoints)
                    {
                        maxPoints = internResult;
                        bestIntern = currentIntern;
                    }
                }
            }

            Console.WriteLine($"Best candidate is {bestIntern} with total {maxPoints} points.");

            foreach (var item in interns.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var contest in item.Value)
                {
                    foreach (var result in contest.OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine($"#  {result.Key} -> {result.Value}");
                    }
                }
            }
        }
    }
}
