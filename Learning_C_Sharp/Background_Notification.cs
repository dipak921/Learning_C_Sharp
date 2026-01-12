using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Background_Notification
    {
        static void StartBackgroundNotification()
        {
            Thread t = new Thread(ShowNotification);
            t.IsBackground = true;   // Background thread
            t.Start();
        }

        static void ShowNotification()
        {
            while (true)
            {
                Console.WriteLine("🔔 Background Notification: New message received!");
                Thread.Sleep(3000);
            }
        }
        static void Main(string[] args)
        {
            StartBackgroundNotification();

            // Main program work
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Main program is running...");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Main program ended");


            Console.ReadLine();
        }
    }
}
