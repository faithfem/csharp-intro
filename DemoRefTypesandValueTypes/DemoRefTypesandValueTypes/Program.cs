using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRefTypesandValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("a: {0}, b: {1}", a, b); //This prints same as line below
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //This prints same as line above

            var arraykcpeTy = new int[3] {1, 2, 3};
            var arraykcpeLy = arraykcpeTy;
            arraykcpeLy[0] = 0;
            Console.WriteLine(arraykcpeLy[1]); //[1] prints 2
        }
    }
}
