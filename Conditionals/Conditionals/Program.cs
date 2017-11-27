using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
}
class Program
    {
        static void Main(string[] args)
        {
            var Season = Season.Autumn;

            switch (Season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn & it's drizzly, yuck!");

                case Season.Summer:
                    Console.WriteLine("It's summer & it's gorgeous!");

                default:
                    Console.WriteLine("It's weird weather out there");
            }
        }
    }

