using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            for (var i = 0; i <name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach(var character in name) //althernative method to lines 13-16
            {
                Console.WriteLine(character);
            }
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
