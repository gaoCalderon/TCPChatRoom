using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Server
{
    public partial class TcpChatServer : Form
    {
        private int portNum;
        TcpListener listener;

        bool done = false;

        public TcpChatServer(int PortNum)
        {
            this.portNum = PortNum;
            listener = null;
        }

        public TcpChatServer()
        {
            InitializeComponent();
        }

        public void StartServer()
        {
            listener = new TcpListener(portNum);
            listener.Start();

            while (!done)
            {
                //ReviewMessageBox.Items.Add("Waiting for Connection");
                //Console.Write("Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();

                //ReviewMessageBox.Items.Add("Connection accepted.");
                //Console.WriteLine("Connection accepted.");
                NetworkStream ns = client.GetStream();


                byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());

                try
                {
                    ns.Write(byteTime, 0, byteTime.Length);
                    //ns.Close();
                    //client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            listener.Stop();

        }


        private void TurnOnServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }
    }
}
