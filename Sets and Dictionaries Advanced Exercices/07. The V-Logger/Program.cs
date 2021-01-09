using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var vloggerFollowers = new Dictionary<string, HashSet<string>>();
            var vloggerFollowing = new Dictionary<string, HashSet<string>>();
            int countVloggers = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input== "Statistics")
                {
                    break;

                }
                else
                {
                    var command= input.Split().ToArray();

                    if (command.Contains("joined"))
                    {
                        
                        string vloggerName = command[0];

                        if (!vloggerFollowers.ContainsKey(vloggerName)&&!vloggerFollowing.ContainsKey(vloggerName))
                        {
                            countVloggers++;
                            vloggerFollowers.Add(vloggerName,new HashSet<string>());
                            vloggerFollowing.Add(vloggerName, new HashSet<string>());
                        }

                    }

                    else if (command.Contains("followed"))
                    {
                        string vloggerFan = command[0];//==vloggerName
                        string followedVlogger = command[2];

                        if (vloggerFan!=followedVlogger)
                        {
                            if (vloggerFollowers.ContainsKey(followedVlogger) && (vloggerFollowing.ContainsKey(vloggerFan)))
                            {
                                vloggerFollowers[followedVlogger].Add(vloggerFan);
                                vloggerFollowing[vloggerFan].Add(followedVlogger);
                            }
                        }
                        
                    }


                    
                }


            }

            Dictionary<string, List<int>> vloggers = new Dictionary<string, List<int>>();
            int maxFollowers = 0;
            string bestVlogger = "";
            int minFollowing = int.MaxValue;
            var bestVloggerFollowers = new HashSet<string>();
            
            foreach (var item in vloggerFollowers)
            {
                int currentVloggersfollowers =item.Value.Count;
                string currentVlogger = item.Key;
                if (currentVloggersfollowers>maxFollowers)
                {
                    maxFollowers = item.Value.Count;
                    bestVlogger = currentVlogger;
                    minFollowing = vloggerFollowing[bestVlogger].Count;
                    bestVloggerFollowers = vloggerFollowers[bestVlogger];
                    

                }
                else if (currentVloggersfollowers==maxFollowers)
                {
                    if (vloggerFollowing[currentVlogger].Count<minFollowing)
                    {
                        bestVlogger = currentVlogger;
                        bestVloggerFollowers = vloggerFollowers[bestVlogger];
                    }
                }
            }
            List<string> followers = new List<string>();

            foreach (var item in bestVloggerFollowers)
            {
                followers.Add(item);
            }
            followers = followers.OrderBy(x => x).ToList();
            Dictionary<string, List<int>> otherVloggers = new Dictionary<string, List<int>>();

            foreach (var vlogger in vloggerFollowers)
            {
                string currentVlogger = vlogger.Key;
                if (currentVlogger!=bestVlogger)
                {
                    otherVloggers.Add(vlogger.Key, new List<int>());
                    otherVloggers[currentVlogger].Add(vloggerFollowers[currentVlogger].Count);
                    otherVloggers[currentVlogger].Add(vloggerFollowing[currentVlogger].Count);
                }
            }

            otherVloggers = otherVloggers
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Value[1])
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {countVloggers} vloggers in its logs.");
            foreach (var vlogger in vloggerFollowers)
            {
                if (vlogger.Key==bestVlogger)
                {
                    Console.WriteLine($"1. {vlogger.Key} : {vloggerFollowers[bestVlogger].Count} followers, {vloggerFollowing[bestVlogger].Count} following");

                    foreach (var item in followers)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                
            }
            int counter = 1;
            foreach (var item in otherVloggers)
            {
                counter++;
                string currentVlogger = item.Key;
                Console.WriteLine($"{counter}. {currentVlogger} : {otherVloggers[currentVlogger][0]} followers, {otherVloggers[currentVlogger][1]} following");

                

            }
           
        }
    }
}
