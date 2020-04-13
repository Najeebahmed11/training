using ConsoleApp2.Maths;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var name = "najeeb ahmed";
            Console.WriteLine("trim: '{0}'",name.Trim());
            Console.WriteLine("trim: '{0}'", name.Trim().ToUpper());
            var index = name.IndexOf(' ');
            var firstName = name.Substring(0, index);
            var lastName = name.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            var split=name.Split(' ');
            Console.WriteLine(split[0]);
            var d=name.Replace('n', 'N');
            Console.WriteLine(d);
            if(string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine(" it is empty");
            }
            var price = 223.233f;
            Console.WriteLine( price.ToString("C"));

        } 
    }
}



