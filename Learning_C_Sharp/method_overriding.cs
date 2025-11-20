using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    //class Device
    //{
    //    public virtual void TureOn()
    //    {
    //        Console.WriteLine("Turning on Generiv Device");
    //    }
    //}
    //class Tv : Device
    //{
    //    public override void TureOn()
    //    {
    //        Console.WriteLine("Tv is on now, showing channeel ");
    //    }
    //}
    //class Ac : Device
    //{
    //    public override void TureOn()
    //    {
    //        Console.WriteLine("AC is on now, cooling now");
    //    }
    //}
    //class music_system : Device
    //{
    //    public override void TureOn()
    //    {
    //        Console.WriteLine("Music system is on now, enjoy now");
    //    }
    //}

    //--------------------------------With parameter--------------------------------------
    class Device
    {
        public virtual void TureOn(string userName, string userType)
        {
            Console.WriteLine($"User Name is :{userName} User Type is: {userType} ");
        }
    }
    class Tv : Device
    {
        public override void TureOn(string userName, string userType)
        {
            Console.WriteLine($"User Name is :{userName} User Type is: {userType} ");
        }
    }
    class Ac : Device
    {
        public override void TureOn(string userName, string userType)
        {
            Console.WriteLine($"User Name is :{userName} User Type is: {userType} ");
        }
    }
    class music_system : Device
    {
        public override void TureOn(string userName, string userType)
        {
            Console.WriteLine($"User Name is :{userName} User Type is: {userType} ");
        }
    }
    internal class method_overriding
    {
        static void Main(string[] args)
        {
            //Device r = new Tv();
            //r.TureOn();
            //Device r1 = new Ac();
            //r1.TureOn();
            //Device r2 = new music_system();
            //r2.TureOn();

            //second example
            Device de = new Device();
            de.TureOn("dipak", "device oprator");
            Device r = new Tv();
            r.TureOn("dipak", "TV oprator");
            Device r1 = new Ac();
            r1.TureOn("dipak", "AC oprator");
            Device r2 = new music_system();
            r2.TureOn("dipak", "Music oprator");
            Device r3 = new music_system();




            Console.ReadLine();
        }
    }
}
