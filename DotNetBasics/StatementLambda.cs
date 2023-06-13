using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class StatementLambda
    {
        public static Action<string> Greet = name =>
          {
              Console.WriteLine("Hello " + name);
          };
    }
}
