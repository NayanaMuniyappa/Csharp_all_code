using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServer;
using System.Windows.Forms;

namespace Windows_server
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            //create channel with port
            TcpChannel tcpChannel = new TcpChannel(8089);
            //register channel
            ChannelServices.RegisterChannel(tcpChannel);
            //create a service class object
            Service service = (Service)Activator.GetObject(typeof(Service),
                "http://localhost:8089/OurFirstRemoteService");
            //"tcp://localhost:8089/OurFirstRemoteService"
            //start calling the functions of the service class
            //Console.WriteLine(service.SayHello("  Remote"));

          
          
          //  Console.Read();
        }

       
    }
}
