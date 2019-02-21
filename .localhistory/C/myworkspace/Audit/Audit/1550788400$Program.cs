using System;
using System.Timers;

namespace Audit
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = TimeSpan.FromSeconds(2).TotalMilliseconds;
            timer.Enabled = true;

            Console.WriteLine("Press any key to quit the program.");
            Console.Read();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var service = new AuditService();
            service.AuditFolder("C:/target", );
        }
    }
}
