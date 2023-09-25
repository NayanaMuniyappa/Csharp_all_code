﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using server;



namespace Assignment7
{
    class client
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //create channel with port
                TcpChannel tcpChannel = new TcpChannel(8002);
                //register channel
                ChannelServices.RegisterChannel(tcpChannel);
                //create a service class object
               Service service = (Service)Activator.GetObject(typeof(Service),
                    "http://localhost:8089/OurFirstRemoteService");
                Console.WriteLine(service.SayHello("  Remote"));
                Console.WriteLine(service.HighestNumber(20, 25));
                Console.Read();
            }
        }
    }
}
            



