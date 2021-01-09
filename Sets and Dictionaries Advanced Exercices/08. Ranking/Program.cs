using System;
using System.Collections.Generic;

namespace _08._Ranking
{
    public class Contest
    {
        public string NameContest { get; set; }
        public int Points { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            var contests = new Dictionary<string, string>();

            while (true)
            {

                var input = Console.ReadLine();

                if (input== "end of contests")
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

            var interns = new Dictionary<string, Contest>();


            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine== "end of submissions")
                {
                    break;
                }

                else
                {
                    var contest = new Contest();

                    var internInfo = inputLine.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                    var  currentContest = internInfo[0];
                    var password = internInfo[1];
                    var userName = internInfo[2];
                    var points = int.Parse(internInfo[3]);

                    if (contests.ContainsKey(currentContest))
                    {
                        if (password==contests[currentContest])
                        {

                            
                            interns.Add(userName, new Contest());
                            contest.NameContest = currentContest;
                            contest.Points = points;
                        }
                    }

                }
            }
        }
    }
}
