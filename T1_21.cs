using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_21
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int term = 0;

            Console.Write("Series: ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;  
                sum += term;

                Console.Write(term);

                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);

            Console.Read();
        }
    }
}
