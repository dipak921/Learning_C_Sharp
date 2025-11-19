using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TYPE OF INHERITANCE 
// 1. SINGLE
// --> It is the type of inheritance in which there is one base class and one derived class
//               SYNTAX
//              class a (base class)
//               {

//               }
//              class b:a (derived class)
//               {

//               }
//--------------------------------------------------------------------------
// 2. HIERACHICAL
//--> This is the type of inheritance in which there are multiple classes derived from one base class.
//--> This type of inheritance is used when there is a requirement of one class feature that is needed in multiple classes.
//               SYNTAX
//              class a (base class)
//               {

//               }
//              class b :a (derived class)
//               {

//               }
//              class b :a (derived class)
//               {

//               }





//-------------------------------------------------------------------------------------------------------------
// 3. MULTI-LEVEL
//--> when one class is derived from another derived class then this type of inheritance is called multilevel inheritance.
//                                  SYNTAX
//                      class A  // Base class
//                       {
//   
//                        }
//                      class B : A  // Derived from A
//                         {

//                         }
//                        class C : B  // Derived from B
//                         {

//                         }

// 4. MULTIPLE (USING INTERFACE)
//--> when



namespace Code_with_harry
{
    // single inheritance
    //class parent
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("Parent class/ base class");
    //    }
    //}
    //class child : parent
    //{
    //    public void show1()
    //    {
    //        Console.WriteLine("Child class / dervied class");
    //    }
    //}

    // end single in heritance

    //----------------HIERACHICAL
    //class parent
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("Parent class/ base class");
    //    }
    //}
    //class child : parent
    //{
    //    public void show1()
    //    {
    //        Console.WriteLine("Child frist class / dervied first class");
    //    }
    //}
    //class child1 : parent//,child
    //{
    //    public void show2()
    //    {
    //        Console.WriteLine("Child second class / dervied second class");
    //    }
    //}

    //----------------Multilevel inherritance

    //   class parent
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("Parent class/ base class");
    //    }
    //}
    //class child : parent
    //{
    //    public void show1()
    //    {
    //        Console.WriteLine("Child frist class / dervied first class");
    //    }
    //}
    //class child1 : child
    //{
    //    public void show2()
    //    {
    //        Console.WriteLine("Child second class / dervied second class");
    //    }
    //}

    // 4. MULTIPLE (USING INTERFACE)

    internal class inheritance_type
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------------------Sigle inheritance------------------");
            //child ch = new child();
            //ch.show();
            //ch.show1();

            //Console.WriteLine("------------------HIERACHICAL inheritance------------------");

            //child1 ch1 = new child1();
            //ch1.show();
            //ch1.show2();

            //Console.WriteLine("------------------Multilevel inheritance------------------");
            //child1 ch1 = new child1();
            //ch1.show();
            //ch1.show1();
            //ch1.show2();

            Console.WriteLine("------------------ MULTIPLE (USING INTERFACE)------------------");


            Console.ReadLine();
        }
    }
}
