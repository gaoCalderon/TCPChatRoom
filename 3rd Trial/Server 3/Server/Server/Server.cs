using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Server
    {
        private int portNum;
        private string hostName;
        TcpListener listener;
        Thread thread;

        public Server(string HostName, int PortNum)
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

                //add thread
                //add binary search tree & dictionary to store users
                //add a queue to store/process incoming messages


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
