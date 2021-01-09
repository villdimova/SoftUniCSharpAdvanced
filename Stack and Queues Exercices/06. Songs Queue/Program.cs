using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();

            var songs = new Queue<string>(input);


            while (true)
            {
                string inputLine = Console.ReadLine();
                List<string> command = inputLine.Split().ToList();


                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }

                else if (command.Contains("Add"))
                {

                    string song = inputLine.Remove(0, 4);


                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }

                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", songs));
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }


            }

        }
    }
}

