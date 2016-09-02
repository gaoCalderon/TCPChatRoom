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

namespace Server
{
    public partial class Server : Form
    {
        Socket socketServer;
        static List<ClientData>//pick up from here
        EndPoint epLocal, epRemote;
        byte[] buffer;
        Thread listenThread = new Thread(ListenThread);
        
        listenThread.Start();

        public Server()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(txtClientIPAddress.Text), Convert.ToInt32(txtServerPort.Text));
            socketServer.Bind(epLocal);

            //connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(    .Text), Convert.ToInt32(  .Text));
            socketServer.Connect(epRemote);

            //Listening to specific port
            buffer = new byte[1500];
            socketServer.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void Server_Load(object sender, EventArgs e)
        {
            //set up socket
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socketServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user IP
            txtClientIPAddress.Text = GetLocalIP();
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

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        static void ListenThread()
        {
            socketServer.Listen();
            //Thread accepClient = new Thread(new ThreadStart(acceptConnection));
            //accepClient.IsBackground = true;
            //accepClient.Start();
        }
    }
}
