﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3.3;
            var c = 2;
            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a - b);
            Console.WriteLine(a % b);
            Console.WriteLine(b % a);
            Console.WriteLine(a + b * c);
            Console.WriteLine(a < b);
            Console.WriteLine(a != b);
        }
    }
}
