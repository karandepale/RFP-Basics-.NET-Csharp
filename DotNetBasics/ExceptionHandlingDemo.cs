using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class ExceptionHandlingDemo
    {
        public  void CheckDivision()
        {
            try
            {
                int x = 100;
                int y = 0;
                int res = x / y;
                Console.WriteLine("Division result is :" + res);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            int rollNum = 1002;
            Console.WriteLine("My roll num is : " + rollNum);
        }
    }
}
