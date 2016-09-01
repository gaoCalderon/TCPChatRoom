using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ServerChatRoom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            TcpListener listen = new TcpListener(IPAddress.Any, 1200);
            listen.Start();

            TcpClient client - listen.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            string ch = Encoding.Unicode.GetString(buffer, 0, data);
            client.Close();
            Console.ReadKey();

        }
    }
}
