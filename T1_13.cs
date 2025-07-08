using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_13
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " "); 

            while (true)
            {
                c = a + b;
                if (c > 55)
                    break;

                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.Read(); 
        }
    }
}
