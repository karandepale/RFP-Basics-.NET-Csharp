using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class EncapsulationGetterSetterProperty
    {
        private int age;

        public int myProperty
        {
            get
            {
                return this.age;
            }
            set
            {
                age = value;
            }
        }
    }
}
