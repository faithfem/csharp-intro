using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec8StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();//can even use a word inside the brackets
            builder.Append('c', 10); //To repeat item btw quotes 10 times
            builder.AppendLine();
            builder.AppendLine("Header");
            builder.AppendLine();
            builder.Append('_', 10);
            //Console.WriteLine(builder);

            //You can use StringBuilder to generate random sequence of characters
            builder.Replace('_', 'x');

            //Or you can ask to remove from string 0, remove first 7 chars or all 10
            builder.Remove(0, 7); //will remove the first 7 "c" in line 14

            //Or you can use StringBuilder to insert new chars
            builder.Insert(0, new string('b', 10)); //inserts 10 b's infront of c's in line 14
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);//add prefix "first char"

            //OR YOU CAN CLEAN THE WHOLE DARN THING ABOVE AS FOLLOWS:
            //HAVE TO COMMENT THE BELOW OUT SO ABOVE CODE WILL RUND

            /*builder
                .Append('c', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('z', 10)
                .Replace('c', 'b')
                .Remove('c', 7)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);//add prefix "first char"*/

        }
    }
}
