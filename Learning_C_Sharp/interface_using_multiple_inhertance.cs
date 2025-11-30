using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    public interface IPhone
    {
        void MakeCall(string number, int duration);
        void SendSMS(string number, string message);
    }

    public interface ICamera
    {
        void TakePhoto(string mode, int resolution);
        void RecordVideo(string format, int duration);
    }

    public class SmartPhone : IPhone, ICamera
    {
        public void MakeCall(string number, int duration)
        {
            Console.WriteLine($"Call this number {number} make a call in {duration}");
        }
        public void SendSMS(string number, string message)
        {
            Console.WriteLine($"send message to this {number} your message is {message}");
        }
        public void TakePhoto(string mode, int resolution)
        {
            Console.WriteLine($"your photo {mode} photo resoulution is {resolution}px");
        }
        public void RecordVideo(string format, int duration)
        {
            Console.WriteLine($"Video formate is {format} in second {duration}");
        }
    }
    internal class interface_using_multiple_inhertance
    {
        static void Main(string[] args)
        {
            SmartPhone phone = new SmartPhone();
            phone.MakeCall("963852742", 10);
            phone.SendSMS("7410529635", "Hello Sir");
            phone.TakePhoto("oldstyle", 1080);
            phone.RecordVideo("Cimamatic", 45);


            Console.ReadLine();
        }
    }
}
