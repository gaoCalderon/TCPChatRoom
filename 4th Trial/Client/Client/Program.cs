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
            TcpClientClass client = new TcpClientClass("192.168.1.100", 7771);
            client.ConnectToServer("192.168.1.100");
        }
    }
}
