using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    class TcpClientClass
    {
        private int portNum;
        private string hostName;
        TcpClient clientSocket;

        public TcpClientClass(string HostName, int PortNum)
        {
            this.portNum = PortNum;
            this.hostName = HostName;
        }

        public void ConnectToServer(string serverIP)
        {

            try
            {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets. TcpClient("192.168.1.100", portNum);

                NetworkStream NStream = client.GetStream();
                
                byte[] data = new byte[1024];
                int bytesRead = NStream.Read(data, 0, data.Length);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, bytesRead));

                SendMessages();
                




                //client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void SendMessages()
        {
            NetworkStream NStream = clientSocket.GetStream();
            byte[] data = new byte[1024];
            int bytesRead = NStream.Read(data, 0, data.Length);
            Console.ReadLine();
        }
    }
}
