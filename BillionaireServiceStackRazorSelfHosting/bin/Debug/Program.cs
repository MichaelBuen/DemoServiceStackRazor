using System;


namespace ﻿BillionaireServiceStackRazorSelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            // ServiceStack.Logging.LogManager.LogFactory = new ServiceStack.Logging.Support.Logging.ConsoleLogFactory();

            var appHost = new AppHost();
            appHost.Init();
            appHost.Start("http://*:2012/");

			System.Diagnostics.Process proc = new System.Diagnostics.Process ();
			proc.StartInfo.UseShellExecute = true;
			proc.StartInfo.FileName = "http://localhost:2012/";
			proc.Start ();

            Console.WriteLine("\n\nListening on http://*:2012/..");
            Console.WriteLine("Type Ctrl+C to quit..");
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}