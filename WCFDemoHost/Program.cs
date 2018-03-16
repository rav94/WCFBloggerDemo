﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFDemoHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                using (host = new ServiceHost(typeof(WCFService_Demo.DemoService)))
                {
                    foreach (var endpoint in host.Description.Endpoints)
                    {
                        Console.WriteLine(endpoint.Address.Uri);
                    }

                    host.Open();
                    Console.WriteLine("The WCFService_Demo Service started at the time: " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Host error:\r\n{0}:\r\n{1}", ex.GetType(), ex.Message));
                Console.ReadLine();
            }

            finally
            {
                // memory clean
                if (host != null)
                    ((IDisposable)host).Dispose();
            }
        }
    }
}
