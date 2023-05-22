using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class VarKeyWord
    {
        public void VarMethod()
        {
            // in  c # we can declare the variable implicit or explicit .
           
            int x = 100; // Explicitely Typed 
            Console.WriteLine( "Vlaue of x using impicitely Typed : " + x);

            var y = 2000; // implicitely typed
            Console.WriteLine("value of y using Explicitely typed : " + y);
        }
    }
}
