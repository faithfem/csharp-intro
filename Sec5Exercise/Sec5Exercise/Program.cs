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
            for (var i = 0; i<=100; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
