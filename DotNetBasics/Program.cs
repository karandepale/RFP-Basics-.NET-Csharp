﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basics of .NET");
            ArrayTopic obj1 = new ArrayTopic();
            obj1.ArrMethod();

            ArrayListDemo obj2 = new ArrayListDemo();
            obj2.ArrayListMethod();

            VarKeyWord obj3 = new VarKeyWord();
            obj3.VarMethod();


        }
    }
}
