using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string newinput = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    newinput += char.ToLower(ch);
                else if (char.IsLower(ch))
                    newinput += char.ToUpper(ch);
                else
                    newinput += ch;
            }

            Console.WriteLine("OUTPUT: " + newinput);
            Console.Read();
        }
    }
}
