
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Lifetime;

namespace server
{
   
    class Server
    {
        public static class Service : MarshalByRefObject
        {
            public string SayHello(string s)
            {
                return "Hello" + s;
            }
        }

        static void Main(string[] args)
        {



            TcpChannel tcpchannel = new TcpChannel(8089);
            //register the channel
            ChannelServices.RegisterChannel(tcpchannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",
              WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started on tcp Port No: 8089...");
            Console.WriteLine("Press any Key to Stop the Server Services..");
            Console.ReadLine();
        }

    }













}
