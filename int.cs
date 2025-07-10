using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class @int
    {
        static void Main(string[] args)
        {
            int a = 2;

            switch (a)
            {
                case 1:
                    Console.WriteLine("a = 1");
                    break;
                case 2:
                    Console.WriteLine("a = 2");
                    break;
                case 3:
                    Console.WriteLine("a = 3");
                    break;
                default:
                    Console.WriteLine("a is not 1, 2, or 3");
                    break;
            }

            Console.ReadLine();
        }
    }
}
