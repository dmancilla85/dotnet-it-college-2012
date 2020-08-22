using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AWMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            FSW.Watcher w = new FSW.Watcher();
            w.StartWatch(@"C:\cursoC#\laboratorio de files system y delegados\Lab 01\Receive", "*.xml");
            Watch(w);

            Console.WriteLine("Presione ENTER cuando desee finalizar.\r\n\r\n");
            Console.ReadLine();
        }

        private static void onNotificationArrived(object sender, FileSystemEventArgs e)
        {
            try
            {
                Console.WriteLine("Nueva PO: " + e.FullPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Watch(FSW.Watcher w)
        {
            w.NewFileHandler += new FSW.Watcher.NewFileEventHandler(onNotificationArrived);
        }
    }
}
