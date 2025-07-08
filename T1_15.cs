using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int originalNum = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }

            if (sum == originalNum)
                Console.WriteLine(originalNum + " is an Armstrong number.");
            else
                Console.WriteLine(originalNum + " is not an Armstrong number.");

            Console.Read();
        }
    }
}
