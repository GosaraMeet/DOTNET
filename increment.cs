using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class increment
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = a++ + ++b + ++b + ++a + ++a;

            Console.WriteLine("Final value of a: " + a);
            Console.WriteLine("Final value of b: " + b);
            Console.WriteLine("Result: " + res);

            Console.ReadLine();
        }
    }
}
