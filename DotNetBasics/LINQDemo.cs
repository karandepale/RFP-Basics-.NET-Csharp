using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class LINQDemo
    {
        public  void LinqDesc()
        {
            Console.WriteLine("Given array elements are:");
            int[] numbers = { 5, 2, 9, 1, 3 };
            foreach (int data in numbers)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("-------------------");
            var descendingOrder = from i in numbers
                                  orderby i descending
                                  select i;
            Console.WriteLine("Descending order of given array element :");
            foreach(int data in descendingOrder)
            {
                Console.WriteLine(data);
            }
        }
    }
}
