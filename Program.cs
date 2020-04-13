using ConsoleApp2.Maths;
using System;
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
            var sentence = "thsi is bbcd sahbh skxb  chdb sxbckscb xbhsc bsxkb";
            Console.WriteLine(sentence.Length);
            if (sentence.Length < 20)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var numberChar = 0;
                var summ = new List<string>();
                foreach (var word in words)
                {
                    summ.Add(word);
                    numberChar += word.Length + 1;
                    if (numberChar > 20)
                    {
                        break;
                    }
                    var ptani=String.Join(" ",summ);
                    Console.Write(ptani);
                }
            }
        } 
    }
}



