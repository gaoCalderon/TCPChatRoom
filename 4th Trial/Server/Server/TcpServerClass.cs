using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class TcpServerClass
    {
        private int portNum;
        private string hostName;
        int counter;
        TcpListener serverSocketListen;
        TcpClient clientSocket;
        HandleClient handleClient;
        Thread thread;

        public TcpServerClass(string HostName, int PortNum)
        {
            this.hostName = HostName;
            this.portNum = PortNum;
            serverSocketListen = null;
        }


        public void StartServer()
        {
            serverSocketListen = new TcpListener(portNum);
            handleClient = new HandleClient();
            serverSocketListen.Start();
            Console.WriteLine("Chat Server Started .....");
            counter = 0;

            while (true)
            {
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;

                Console.Write("Waiting for connection...");
                clientSocket = serverSocketListen.AcceptTcpClient();
                counter += 1;
                Console.WriteLine("Connection accepted.");
                NetworkStream NStream = clientSocket.GetStream();
                NStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                handleClient.clientsList.Add(dataFromClient, clientSocket);

                handleClient.broadcast(dataFromClient + " Joined ", dataFromClient, false);

                Console.WriteLine(dataFromClient + " Joined chat room ");
                handleClient.startClient(clientSocket, dataFromClient, handleClient.clientsList);

                byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());
                NStream.Write(byteTime, 0, byteTime.Length);

                Console.WriteLine("create client Thread");
                thread = new Thread(ProcessClientRequests);
                thread.Start(clientSocket);

                try
                {
                    //ns.Close();
                    //client.Close();
                    //add method access Search
                
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            //listener.Stop();

        }

        private static void ProcessClientRequests(object arguement)
        {
            TcpClient client = (TcpClient)arguement;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                string s = String.Empty;
                while(!(s = reader.ReadLine()).Equals("Exit") || (s == null))
                {
                    Console.WriteLine("From Client -> " + s);
                    Console.WriteLine("From Server -> " + s);
                    writer.Flush();
                }
                reader.Close();
                writer.Close();
                //client.Close();
                Console.WriteLine("Closing client connection!");
            }
            catch (IOException)
            {
                Console.WriteLine("Problems with client communication. Exiting thread");
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }


        



    }
}
