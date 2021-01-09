using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            int a = 10;

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
