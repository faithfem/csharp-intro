using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec9_Lecture73_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIRECTORY & DIRECTORY INFO (LIKE FILE & FILE INFO) PROVIDE STATIC & INSTANCE METHODS
            //(I) DIRECTORY          
            Directory.CreateDirectory(@"c:\temp\folder1");

            //BELOW CODE WILL SHOW ALL FILES IN THE FOLDER SHOWN
            var files = Directory.GetFiles(@"C:\Coding\Projects\CSharpFundamentals", "*.*"); //Has 3 overloads
            foreach (var file in files)
                Console.WriteLine(file);

            //TO RETURN ALL THE DIRECTORIES
            var directories = Directory.GetDirectories(@"C:\Coding\Projects\CSharpFundamentals", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            //TO SEE IF A DIRECTORY EXISTS
            Directory.Exists("...");


            //(II) DIRECTORY INFO

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories()
        }
    }
}
