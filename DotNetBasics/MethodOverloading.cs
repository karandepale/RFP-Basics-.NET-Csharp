using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class MethodOverloading
    {
        // Method overloading 
        public void Display(String EmpName , int EmpSalary )
        {
            Console.WriteLine("Display first method");
            Console.WriteLine("Employee Name :" + EmpName + " , " + "Employee Salary :" + EmpSalary);
        }

        public void Display(int a , int b)
        {
            Console.WriteLine("Display second method");
            int res = a + b;
            Console.WriteLine("Addition of A and B is: " + res);
        }

    }
}
