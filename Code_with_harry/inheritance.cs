using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inheritance
//-->The similarity in physical features of a child to that of its parents is due to the child having inherited these features from its parents.
//--> Similarly, in c# inheritance allows you to create a class by deriving the common attributes and method of an existing class.
//--> Inheritance provides reusability by allowing us to extend an exsting class.
//-->The reason behind oop programmin it to promote the reusabiliity of code and to reduce complexity in code and it is possible by using inheritance.

//BASE CLASS
//--> IS THE    CLASS from which features are to be inherited into another class
//--> it is the class in which the base class features are inherited.




class employees
{
    public int empid;
    public string name;
    public int age;
    public int contactNumber;

}
class visitingemployees : employees
{
    public int visitingSalary;
    public int visitingHourse;

}
class permentemployees : employees
{
    public int ParmentSalary;
    public int ParmentHourse;
}

namespace Code_with_harry
{
    internal class inheritance
    {
        static void Main(string[] args)
        {
            permentemployees dipak = new permentemployees();
            dipak.age = 10;
            Console.WriteLine(dipak.age);

            Console.ReadLine();
        }
    }
}
