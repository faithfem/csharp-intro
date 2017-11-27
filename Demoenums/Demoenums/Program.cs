using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoenums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //Prints "3" because you asked for integer of "Express"

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //Prints "express" because methodId 3 is express

            Console.WriteLine(method.ToString()); //Prints "express" coz of the ToString bit

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
