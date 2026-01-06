using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Login
    {
        public virtual void LoginUser()
        {
            Console.WriteLine("Loggin In");
        }
    }
    class AdminLogin : Login
    {
        public override void LoginUser()
        {
            Console.WriteLine("Admin Login");
            Console.WriteLine("Access - Full Control");
        }
    }
    class UserLogin : Login
    {
        public override void LoginUser()
        {
            Console.WriteLine("User Login");
            Console.WriteLine("Minimum Access");
        }
    }

    class GusetLogin :Login
    {
        public override void LoginUser()
        {
            Console.WriteLine("Gust Login");
            Console.WriteLine("Only View");
        }
    }
    internal class Function_overriding_Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Guset");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Login l = new AdminLogin();
                    l.LoginUser();
                    break;
                case 2:
                    Login m = new UserLogin();
                    m.LoginUser();
                    break;
                case 3:
                    Login n = new GusetLogin();
                    n.LoginUser();
                    break;
                default :
                    Console.WriteLine("Invalid");
                    break;


            }






            Console.ReadLine();
        }
    }
}
