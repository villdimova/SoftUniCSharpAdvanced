using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split().ToList();

            var inputInfo = new Stack<string>(input);
            
            var hallGuests = new List<int>();
            var openHalls = new Queue<string>();

            
            while (inputInfo.Count>0)
            {
                string currentInfo = inputInfo.Peek();
                if (char.IsLetter(currentInfo[0]))
                {

                    openHalls.Enqueue(currentInfo);
                    inputInfo.Pop();

                }
                else
                {
                    if (openHalls.Count==0)
                    {
                        inputInfo.Pop();
                        continue;
                    }
                    else
                    {
                        if (int.Parse(currentInfo)+ hallGuests.Sum()<=hallCapacity)
                        {
                            inputInfo.Pop();
                            hallGuests.Add(int.Parse(currentInfo));
                        }
                        else
                        {
                            if (openHalls.Count==0)
                            {
                                inputInfo.Pop();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"{openHalls.Peek()} -> {String.Join(", ", hallGuests)}");

                                openHalls.Dequeue();
                                inputInfo.Pop();
                                hallGuests = new List<int>();
                                if (openHalls.Count>0)
                                {
                                    hallGuests.Add(int.Parse(currentInfo));
                                }
                                else
                                {
                                    continue;
                                }
                                
                            }
                        }
                    }
                }

            }



        }
    }
}
