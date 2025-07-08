﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine().ToUpper()); 

            if (gender == 'M')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender input. Please enter M or F.");
            }

            Console.Read();
        }
    }
}
