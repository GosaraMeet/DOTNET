﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class T1_10
    {
        static void Main()
        {
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            string hide = mobile.Substring(0, 5) + "XXXXX";

            Console.WriteLine("Masked Mobile Number: " + hide);
        }
    }

}
