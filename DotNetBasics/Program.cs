using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetBasics.MultiLevelInheritance;
using static DotNetBasics.SingleLevelInheritance;

namespace DotNetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Basics of .NET");
            //ArrayTopic obj1 = new ArrayTopic();
            // obj1.ArrMethod();

            //ArrayListDemo obj2 = new ArrayListDemo();
            //obj2.ArrayListMethod();

            //VarKeyWord obj3 = new VarKeyWord();
            //obj3.VarMethod();

            // Default constructor OR Parameterless Constructor
            // DefaultConstructor obj4 = new DefaultConstructor();
            // Console.ReadLine();


            // Parameterized constructor
            // ParameterizedConstructor obj5 = new ParameterizedConstructor(10, 20, "Karan");
            // Console.ReadLine();

            // ------------------------- INHERITANCE -------------------------------------
            // Single Level Inheritance
            //ChildClass obj4 = new ChildClass();
            //obj4.DisplayEmpDetail();

            //MULTI LEVEL INHERITANCE
            Child obj5 = new Child();
            obj5.DisplayDetail();
            obj5.DisplayEmpDetailOnParent();


        }
    }
}
