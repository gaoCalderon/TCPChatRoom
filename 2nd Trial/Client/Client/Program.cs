﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {

        static void Main(string[] args)
        {
            TcpTimeClient client = new TcpTimeClient("10.2.20.27", 7771);
            client.ConnectToServer();
        }
    }
}
