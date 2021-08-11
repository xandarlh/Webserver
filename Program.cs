using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Webserver
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress iPAddress = IPAddress.Parse("10.108.168.253");
            Webserver webserver = new Webserver();
            webserver.start(iPAddress, 80, 2, @"C:\ting");
            Console.Read();
        }
    }
}
