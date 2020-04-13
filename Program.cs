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
            //var firstName = "najeeb";
            //foreach(var character in firstName)
            //{
            //    Console.WriteLine(character);
            //}
            var jaggedArray =new int[3][];
            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[5];
            jaggedArray[2]=new int[3];
            var myList = new List<int>() { 1, 2, 3, 2, 3 };
            var myDate = new DateTime(2020, 3, 4);
            var now = DateTime.Today;
            Console.WriteLine(now);
            var tomorrow = now.AddDays(33);
            Console.WriteLine(now.ToLongDateString());
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(23);
            var tomespan = end - start;
            Console.WriteLine(tomespan);


        }
    }
}



