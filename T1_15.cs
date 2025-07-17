using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_15
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int original = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum = sum + (digit * digit * digit);
                number = number / 10;
            }

            if (sum == original)
            {
                Console.WriteLine(original + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(original + " is not an Armstrong number.");
            }
        }
    }
}