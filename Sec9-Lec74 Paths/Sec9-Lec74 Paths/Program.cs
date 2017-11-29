using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec9_Lec74_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO SHOW THE PATH OF FILES AND DIRECTORIES

            var path = @"C:\Coding\Projects\CSharpFundamentals\WhileLoops\WhileLoops.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
