using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string firstPart = mobile.Substring(0, mobile.Length - 5); 
                string masked = firstPart + "XXXXX"; 
                Console.WriteLine("Masked Mobile Number: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Must be at least 5 digits.");
            }

            Console.Read();
        }
    }
}
