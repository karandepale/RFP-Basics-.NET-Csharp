using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i , int j , String name)
        {
            int sumOfTwo = i + j;
            Console.WriteLine("Sum of i and j is: " + sumOfTwo);
            Console.WriteLine("My name : " + name);
        }
    }
}
