using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demostrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Faith";
            var lastName = "efm";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            var text = "Hi John\nLook into paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var textt = @"Hi John
Look into paths
c:\folder5\folder6
c:\folder7\folder8";
            Console.WriteLine(text);
            Console.WriteLine(textt);
        }
    }
}
