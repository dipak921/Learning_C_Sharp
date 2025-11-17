using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    //Constructors in c#
    //--a class constructor is a special member function of a class that is executed whenever we create new object of that class
    //-- a constructor has exactly the same name as that of class and it does not have any return type
    
    //Default constuctor 
    // a constucto which has not defined any parametes or we can say without any parametes is called default constructo. it initializes the same value of every instance of class.
    
    // Parameterized constructor
    // -- A constructor which has at least one parameter is called parameterizes constructor. Using this type of constructor we can initialize each instance of the class to different values. 
    internal class Constructor
    {
        // Default Constructors
        //public Constructor() 
        //{
        //    Console.WriteLine("Constructor invokes !");
        //}
        // Parameterized constructor
        int EmpId;
        string EmpName;
        int EmpAge;
        public Constructor(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }
        //Getter Method
        public int getId()
        {
            return this.EmpId;
        }
        public string getName()
        {
            return this.EmpName;
        }
        public int getAge()
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            // Default Constructors
            //Constructor c = new Constructor(); 

            // Parameterized constructor
            Constructor dipak = new Constructor(101,"Dipak",21);
            Constructor anna = new Constructor(102,"Annasaheb",23);

            Console.WriteLine("Employee id is :{0}",dipak.getId());
            Console.WriteLine("Employee Name is :{0}",dipak.getName());
            Console.WriteLine("Employee Age is :{0}",dipak.getAge());

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Employee id is :{0}", anna.getId());
            Console.WriteLine("Employee Name is :{0}", anna.getName());
            Console.WriteLine("Employee Age is :{0}", anna.getAge());




            Console.ReadLine();
        }
    }
}
