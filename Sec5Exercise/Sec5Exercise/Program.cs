using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                //Console.WriteLine(i);
                count++;
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3", count);
        }
    }
}

