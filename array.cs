using System;

namespace DOTNET
{
    internal class array
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
