using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.Tagram
{
    public class User
    {
        public User(string username, Dictionary<string, int> tags)
        {
            this.Username = username;
            this.Tags =tags;

        }

        public string Username { get; set; }
        public Dictionary<string, int> Tags { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    var userInfo = input.Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (userInfo[0] == "ban")
                    {
                        string bannedUsername = userInfo[1];
                        if (users.ContainsKey(bannedUsername))
                        {
                      
                            users.Remove(bannedUsername);
                        }
                    }
                    else
                    {
                        string userName = userInfo[0];
                        string tag = userInfo[1];
                        int likes = int.Parse(userInfo[2]);

                        if (users.ContainsKey(userName))
                        {
                           
                            if (users[userName].ContainsKey(tag))
                            {
                                users[userName][tag] += likes;
                            }
                            else
                            {
                                users[userName].Add(tag, likes);

                            }
                        }
                        else
                        {
                            Dictionary<string, int> currentTag = new Dictionary<string, int>();
                            currentTag.Add(tag, likes);
                            
                            users.Add(userName,currentTag);


                        }

                    }
                    
                }
            }

            
            foreach (var username in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Keys.Count))
            {
                Console.WriteLine(username.Key);

                foreach (var item in username.Value)
                {
                    Console.WriteLine($"- {item.Key}: {item.Value}");
                }
            }

        }
    }
}
