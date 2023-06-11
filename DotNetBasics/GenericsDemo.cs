using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class GenericsDemo
    {
        public void SwapTowInput <T>(ref T a ,ref T b)
        {
            T temp = a;
            a = b;
            b = temp ;
        }
    }
}
