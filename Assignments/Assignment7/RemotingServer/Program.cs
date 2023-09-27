using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServer
{
    public class Service : MarshalByRefObject
    {

        public int HighestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Max(n1, n2));

            return maxnumber;
        }
    }
    //server class
    //it hosts the services by registering them
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel tcpchannel = new TcpChannel(8089);
            //register the channel
            ChannelServices.RegisterChannel(tcpchannel, false);
            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",
                WellKnownObjectMode.Singleton);

        }

    }
}
