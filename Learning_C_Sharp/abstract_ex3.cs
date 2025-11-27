using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    abstract class Message
    {
        public string RecipientName;
        public string MessageSubject;
        public void showBasicInfo()
        {
            Console.WriteLine($"RecipientName is :{RecipientName} ,Subject of Message : {MessageSubject}");
        }
        public abstract void SendNotification();
    }
    class EmailNotification : Message
    {
        public string EmailAddress;

        public override void SendNotification()
        {
            Console.WriteLine("Sending Email notification to :{0}",EmailAddress);
            Console.WriteLine("Email notification sent successfully");
        }
    }
    class SMSNotification : Message
    {
        public string SMSAddress;
        public override void SendNotification()
        {
            Console.WriteLine("Sending SMS notification to +91-{0}",SMSAddress);
            Console.WriteLine("SMS notification sent successfully");
        }
    }
    class PushNotificaton : Message
    {
        public string TokenNumber;
        public override void SendNotification() 
        {
            Console.WriteLine($"Sending Push notification to : {TokenNumber}");
            Console.WriteLine("Push notification sent successfully");
        }
    }
        internal class abstract_ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Email Notification---------------------------");
            EmailNotification m = new EmailNotification();
            m.RecipientName = "Miss. Rutuja";
            m.MessageSubject = "Your Order is Placed";
            m.EmailAddress = "rutuja987@gmail.com";
            m.showBasicInfo();
            m.SendNotification();
            Console.WriteLine();
            Console.WriteLine("-------------------SMS Notification---------------------------");
            Message s = new SMSNotification()
            {
                RecipientName = "Mr.Om",
                MessageSubject = "Account Credited",
                SMSAddress = "9638527413",
            };
            s.showBasicInfo();
            s.SendNotification();
            Console.WriteLine();
            Console.WriteLine("-------------------SMS Notification---------------------------");
            Message p = new PushNotificaton()
            {
                RecipientName = "Miss. Neha",
                MessageSubject = "New Alert",
                TokenNumber = "1adg23tyinT45akLmnG",
            };
            p.showBasicInfo();
            p.SendNotification();
            Console.ReadLine();
        }
    }
}
