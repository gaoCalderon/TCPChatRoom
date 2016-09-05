using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    class TcpTimeClient
    {
        private int portNum;
        private string hostName;

        public TcpTimeClient(string HostName, int PortNum)
        {
            this.portNum = PortNum;
            this.hostName = HostName;
        }

        public void ConnectToServer()
        {
            try
            {
                TcpClient client = new TcpClient("192.168.1.100", portNum);
                //TcpClient client = new TcpClient("10.2.20.27", portNum);

                NetworkStream ns = client.GetStream();
                
                byte[] bytes = new byte[1024];
                int bytesRead = ns.Read(bytes, 0, bytes.Length);

                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));


                //client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void MessageCallBack()
        {

        }
    }
}
