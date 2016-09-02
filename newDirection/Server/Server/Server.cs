using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Server
    {
        private TcpListener _tcpListener;
        private readonly int _packetSize = 64;

        private int _clientCount;
        private readonly int _maxClientCount;
        private Dictionary<IPAddress, TcpClient> _clients;
        private readonly object _token = new object();

        public Action<byte[], TcpClient> OnDataReceive;

        public bool Running { get; set; }

        public int Port
        {
            get { return ((IPEndPoint)_tcpListener.Server.LocalEndPoint).Port; }
        }

        public Dictionary<IPAddress, TcpClient> TcpClients
        {
            get { return _clients; }
        }

        public Server(int port, int maxClientCount)
        {
            _clientCount = 0;
            _maxClientCount = maxClientCount;
            _clients = new Dictionary<IPAddress, TcpClient>(_maxClientCount);

            try
            {
                _tcpListener = new TcpListener(IPAddress.Any, port);
            }
            catch (Exception e)
            {
                CommandLine.Write(e.Message);
            }
        }

        public void StartListen()
        {
            try
            {
                Running = true;
                _tcpListener.Start();
                Console.WriteLine("Started Listening at port " + Port + ".");
            }
            catch (Exception e)
            {
                CommandLine.Write(e.Message);
            }

            while (Running)
            {
                lock (_token)
                {
                    if (_clientCount >= _maxClientCount) { continue; }
                }
                var newClient = _tcpListener.AcceptTcpClient();
                AddClient(newClient);
            }
        }

        public void StopLiten()
        {
            try
            {
                Running = false;
                _tcpListener.Stop();
                Console.WriteLine("Stop Listening at port " + Port + ".");
            }
            catch (Exception e)
            {
                CommandLine.Write(e.Message);
            }
        }

        public void Send(TcpClient client, string data)
        {
            if (client == null || !client.Connect()) return;

            var mesg = new Message(data);

            try
            {
                client.Stream.Write(mesg.Data, 0, mesg.Data.Length);
            }
            catch (Exception e)
            {
                CommandLine.Write(e.Message);
            }
        }

        public void SendAll(string data)
        {
            foreach (var entry in _clients) { Send(entry.Value, data); }
        }

        private void AddClient(TcpClient newClient)
        {
            if (newClient == null) return;

            var client = new TcpClient();
            _clients.Add(client.IP, client);
            IncreaseClientCount();

            var clientThread = new Thread(HandleClient) { IsBackground = true };
            clientThread.Start(client);

            CommandLine.Write("A new client coonnected. Client count is " + _clientCount + ".");
        }
        
        private void RemoveClient(TcpClient client)
        {
            if (client == null) return;

            _client.Remove(client.IP);
            DecreaseClientCount();

            client.Close();
        }

        private void HandleClient(object newClient)
        {
            var client = (TcpClient)newClient;
            var currentMessage = new List<byte>();

            while (true)
            {
                var readMessage = new byte[_packetSize];
                int readMessageSize;
                try
                {
                    readMessageSize = client.Stream.Read(readMessage, 0, _packetSize);
                }
                catch (Exception e)
                {
                    CommandLine.Write(e.Message);
                }

                if (readMessageSize <= 0)
                {
                    CommandLine.Write("The client [" + client.IP + "] has closed the connection.");
                    break;
                }

                foreach (var b in readMessage)
                {
                    if (b == 0) break;
                    if (b == 4)
                    {
                        OnDataReceive(currentMessage.ToArray(), client);
                        currentMessage.Clear();
                    }
                    else
                    {
                        currentMessage.Add(b);
                    }
                }
            }

            CommandLine.Write("Communication ended with client {" + client.IP + "].");
            RemoveClient(client);
        }

        private void IncreaseClientCount()
        {
            lock (_token) { _clientCount++; }
        }

        private void DecreaseClientCount()
        {
            lock (_token) { _clientCount--; }
        }

        

    }
}
