using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("OUTPUT: " + upperName);

            Console.ReadLine();
        }
    }
}
