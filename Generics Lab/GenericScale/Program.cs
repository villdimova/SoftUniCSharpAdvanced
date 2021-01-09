using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int left = 3;
            int right = 6;

            EqualityScale<int> equalScale = new EqualityScale<int>(left, right);

            if (equalScale.AreEqual())
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }
    }
}
