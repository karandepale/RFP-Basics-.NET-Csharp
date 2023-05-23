using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class SingleLevelInheritance
    {
        public class parentClass
        {
            String EmpName = "Karan";
            int Salary = 300000;
            public void DisplayEmpDetail()
            {
                Console.WriteLine("Parent Class :-");
                Console.WriteLine("EmployeeName: " + EmpName + " , " + "Salary: " + Salary);
            }
        }

        public class ChildClass : parentClass
        {

        }
    }
}
