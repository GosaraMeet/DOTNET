using System;

namespace DOTNET
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");

            Console.ReadKey();
        }
    }
}

/*
a = a + b;  //a = 30 & b = 20

b = a - b;  //a = 30 & b = 10

a = a - b;  //a = 20 & b = 10

*/