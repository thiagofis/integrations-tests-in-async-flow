using System;
using System.Timers;

namespace Audit
{
    internal class Program
    {
        private const string path = "C:/target";
         
        private static void Main(string[] args)
        {
            Timer timer = new Timer();

            ElapsedEventHandler handler = new ElapsedEventHandler(OnTimedEvent);
            timer.Elapsed += handler;
            timer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;
            timer.Enabled = true;
            timer.Start();


            //trigger manually the first time
            OnTimedEvent(null, null);

            Console.WriteLine("Press any key to quit the program.");
            Console.Read();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var service = new AuditService();
            service.AuditFolderAsync(path);
        }
    }
}