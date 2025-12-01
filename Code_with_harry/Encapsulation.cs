using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ENCAPSULATION
--> Encapsulation is one of the four fundamental opp concepts. 
The other three are inheritance, polmorphism, and abstraction
--> Encapsulation in C# is a mechanism of wrapping the data (variable)
and code acting on the data (methods or properties) together as a signle unit.
--> In encapsulation, the variable of a class will be hidden from other classes, 
and can be accessed only throgh the methods or properties of their current class.
Therefore, it is also known as data hiding.

 */
namespace Code_with_harry
{
    class Person
    {
        private string Name;
        private int Age;

        public void setName(string Name)
        { 
            if(string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is requid.");
            }
            else
            {
                this.Name = Name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
            }
            else
            {
              Console.WriteLine("your name is:" +this.Name);
            }
        }
        public void setAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age should not be negative or zero");
            }
        }
        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("your age  is." + this.Age);
            }
            else
            {
            }
        }
    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setName("dipak");
            p.getName();
            p.setAge(-23);
            p.getAge();
            
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Age);


            Console.ReadLine();
        }
    }
}
