﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Server server = new Server("192.168.1.100", 7771);
            server.StartServer();

            

        }
    }

    
}
