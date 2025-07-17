using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_20
    {
        public static void Main()
        {
            int k = 1;
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }

    }
}