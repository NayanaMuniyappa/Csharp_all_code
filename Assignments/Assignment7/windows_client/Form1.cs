using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServer;



namespace windows_client
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {

            //create channel with port
            TcpChannel tcpChannel = new TcpChannel(8089);

            //register channel
            ChannelServices.RegisterChannel(tcpChannel);

            //create a service class object
            service = (Service)Activator.GetObject(typeof(Service),
                "tcp://localhost:8089/OurFirstRemoteService");

            //"tcp://localhost:8089/OurFirstRemoteService"
            //start calling the functions of the service class

            int number1 = int.Parse(n1.Text);
            int number2 = int.Parse(n2.Text);

            res.Text = service.HighestNumber(number1, number2).ToString();


        }
    }
}
