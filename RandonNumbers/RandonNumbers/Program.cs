using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandonNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i<10; i++)
            {
                //Console.WriteLine(random.Next(97, 122)); //Can leave brackets empty unless you want to define the range of the random numbers
                
                Console.WriteLine((char)('a' + random.Next(0, 26)));//Prints random numbers between those ranges but in character (alpha) format
            }

            //Console.WriteLine((int)'a');
        }
    }
}
