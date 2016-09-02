using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class Main : Form
    {
        Socket socketClient;
        EndPoint endPointLocal, endPointRemote;
        byte[] buffer;

        public Main()
        {
            InitializeComponent();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //binding Socket
            endPointLocal = new IPEndPoint(IPAddress.Parse(txtClientIPAddress.Text), Convert.ToInt32(txtServerPort.Text));
            socketClient.Bind(endPointLocal);

            //connect to remote IP
            endPointRemote = new IPEndPoint(IPAddress.Parse(     .Text), Convert.ToInt32(    .Text));
            socketClient.Connect(endPointRemote);

            //Listening to specific port
            buffer = new byte[1500];
            socketClient.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //set up socket
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socketClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user IP
            txtClientIPAddress.Text = GetLocalIP();
            textFriendIp.Text = GetLocalIP();
        }
    }
}
