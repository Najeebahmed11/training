using ConsoleApp2.Maths;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append('n', 10);
            
            stringBuilder.Append("header");
            Console.WriteLine(stringBuilder);
            stringBuilder.AppendLine();
            stringBuilder.Replace('n', '+');
            Console.WriteLine(stringBuilder);
            stringBuilder.Remove(0, 8);
            Console.WriteLine(stringBuilder);
            //in string builder we are not getting string searching methods
            //we can chain all these methods as they retuirn string builder


        } 
    }
}



