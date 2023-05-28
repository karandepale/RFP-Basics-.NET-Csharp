﻿using System;
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
            // Child obj5 = new Child();
            //obj5.DisplayDetail();
            //obj5.DisplayEmpDetailOnParent();


            // Multiple Inheritance
            //Smartphone obj6 = new Smartphone();
            //obj6.GetPhoneDetail();
            //obj6.GetCameraDetail();


            //----------------------------------- POLYMORPHISM --------------------------------
            //MethodOverloading obj7 = new MethodOverloading();
            //obj7.Display("Karan", 300000);
            //obj7.Display(100, 200);


            //Child obj8 = new Child();
            //obj8.Display(5, 5);



            //------------------------ ENCAPSULATION ---------------------------------------
            // Encapsulation obj9 = new Encapsulation();
            //obj9.Get();

            // EncapsulationGetterSetterProperty obj10 = new EncapsulationGetterSetterProperty();
            //obj10.myProperty



            //--------------------- ABSTRACTION -----------------------------------------
            Animal objDog = new Dog();
            objDog.Sound();

            Animal objCat = new Cat();
            objCat.Sound();




            // ------------------------- LIST----------------------------------
            /*        ListProgram obj1 = new ListProgram()
                    {
                        name = "karan",
                        age = 23,
                        salary = 1000
                    };

                    ListProgram obj2 = new ListProgram()
                    {
                        name = "Manoj",
                        age = 25,
                        salary = 5000
                    };

                    List <ListProgram> list = new List <ListProgram> ();
                    list.Add(obj1);
                    list.Add(obj2);

                    foreach(var item in list)
                    {
                        Console.WriteLine("Name: " + item.name + " , " + " Age: " + item.age + " , " + "salary: " + item.salary);
                    }

                    */












        }
    }
}
