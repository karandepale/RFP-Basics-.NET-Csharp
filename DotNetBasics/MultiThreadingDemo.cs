using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class MultiThreadingDemo
    {
       public  void PrintNum()
        {
            for(int i=1;  i<=10;  i++)
            {
                Console.WriteLine("PrintNum: " + i);
            }
        }

        public  void SayHellow()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Hello and welcome to the world of programming...");
        } 

        public  void TablePrint()
        {
            for(int i=1;  i<=10; i++)
            {
                Console.WriteLine( "Table is:" + i * 2);
            }
        }
    }
}
