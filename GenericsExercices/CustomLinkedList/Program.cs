using System;

namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddLast("My");
            doublyLinkedList.AddLast("Name");
            doublyLinkedList.AddLast("Is");

            Console.WriteLine(doublyLinkedList.Contains("My"));
            Console.WriteLine(doublyLinkedList.Contains("Vill"));

        }
    }
}
