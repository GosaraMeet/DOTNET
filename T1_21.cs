﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_21
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter the number of terms : ");
            int term = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            int current = 0;
            int sum = 0;

            for (int i = 1; i <= term; i++)
            {
                current = current * 10 + no;
                Console.Write(current);

                if (i != term)
                {
                    Console.Write(" + ");
                } 
                sum += current;
            }
            Console.WriteLine();

            Console.WriteLine("The Sum is : {0}", sum);
            Console.Read();
        }
    }
}
