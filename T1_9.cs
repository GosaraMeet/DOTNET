using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            StringBuilder toggleName = new StringBuilder();

            foreach (char c in name)
            {
                if (char.IsUpper(c))
                    toggleName.Append(char.ToLower(c));
                else if (char.IsLower(c))
                    toggleName.Append(char.ToUpper(c));
                else
                    toggleName.Append(c);  
            }

            Console.WriteLine(toggleName.ToString());

            Console.Read();
        }
    }
}
