﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your text");
            string input = Console.ReadLine();


            Console.WriteLine($"lower: {input.ToLower()}, upper {input.ToUpper()}, {input}");

            Console.ReadLine();
        }
    }
}
