using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    class TcpServer
    {
        private int portNum;
        private string hostName;
        TcpListener listener;

        public TcpServer(string HostName, int PortNum)
        {
            this.hostName = HostName;
            this.portNum = PortNum;
            listener = null;
        }

        bool done = false;

        public void StartServer()
        {
            listener = new TcpListener(portNum);
            listener.Start();

            while (!done)
            {
                Console.Write("Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Connection accepted.");
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
    }
}
