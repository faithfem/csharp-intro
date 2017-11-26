using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int j = 100;
            byte a = (byte)j;
            Console.WriteLine(a);

            var number = "1234";
            int x = Convert.ToInt32(number);
            Console.WriteLine(x);

            try
            {
                var num = "700";
                byte y = Convert.ToByte(num);
                Console.WriteLine(y);
            }
            catch (Exception)
            {
                //throw;
                Console.WriteLine("The number could not be converted to a byte");
            }

        }
    }
}
