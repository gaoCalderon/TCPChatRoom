﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace ChatApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TcpClient client = new TcpClient( ); //need to place IP Address in parameters
            NetworkStream n = client.GetStream();
            string ch = Console.ReadLine();
            byte[] message = Encoding.Unicode.GetBytes(ch);
            n.Write(message, 0, message.Length);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            client.Close();
            Console.ReadKey();
        }
    }
}
