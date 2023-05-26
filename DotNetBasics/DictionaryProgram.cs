using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class DictionaryProgram
    {
        static void Main(String[] args)
        {
            //------------------------- DICTIONARY-------------------------------------

            Dictionary<string, int> st = new Dictionary<string, int>();
            st.Add("Karan", 1000);
            st.Add("Krishna", 2000);
            st.Add("manoj", 3000);

            foreach(var itm in st)
            {
                Console.WriteLine(itm);
            }
        }
    }
}
