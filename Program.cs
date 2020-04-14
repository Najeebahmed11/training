using ConsoleApp2.Maths;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Channels;
using System.IO;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\olx poster");
            var currentfFiles=Directory.GetFiles(@"D:\internship", "*.cs",SearchOption.AllDirectories);
            foreach(var file in currentfFiles)
            {
                Console.WriteLine(file);
            }
            //same for directory Directory.getdirectory....
            Directory.Exists("......");
            var directoryinfo = new DirectoryInfo("...");
            directoryinfo.GetFiles();
            directoryinfo.GetDirectories();


        } 
    }
}



