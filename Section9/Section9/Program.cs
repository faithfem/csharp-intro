using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            // FILE COPY - PROVIDES STATIC METHODS
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg",true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path); // To read all text in a file. Takes a path and returns a string

            //FILE INFO: PROVIDES INSTANCE METHODS FIRST CREATE AN OBJECT

            var fileInfo = new FileInfo(path); // Specify the path. To copy this file, see line below
            fileInfo.CopyTo("...");
            fileInfo.Delete(); //If you want to delete, do this, no parameters
            if (fileInfo.Exists);//To find if file exists and this is not a method, it's a property
            {
                // do something
            }

        }

    }
}
