using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpServer server = new TcpServer("192.168.1.100", 7771);
            server.StartServer();

        }
    }
}
