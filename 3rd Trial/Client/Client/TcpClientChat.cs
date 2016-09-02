﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class TcpClientChat : Form
    {
        //Socket socket;
        //EndPoint endPointLocal;
        private string hostName;
        TcpClient client;
        NetworkStream stream;
        Int32 Port = 7771;

        public TcpClientChat(string HostName)
        {
            
            this.hostName = HostName;
        }


        public TcpClientChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToServer("10.0.20.27", "connected");

            //bind socket
            //endPointLocal = new IPEndPoint(IPAddress.Parse("10.2.20.27"), Convert.ToInt32(Port));
            //socket.Bind(endPointLocal);
        }

        private void ConnectToServer(string serverIP, string message)
        {
            string output = "";

            try
            {
                client = new TcpClient("10.2.20.27", Port);

                Byte[] data = new Byte[256];
                data = System.Text.Encoding.ASCII.GetBytes(message);

                stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                output = "Sent: " + message;
                System.Windows.Forms.MessageBox.Show(output);

                data = new Byte[256];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                output = "Received: " + responseData;
                System.Windows.Forms.MessageBox.Show(output);

                //stream.Close();
                //client.Close();
            }
            catch (ArgumentNullException e)
            {
                output = "ArgumentNullException: " + e;
                System.Windows.Forms.MessageBox.Show(output);
            }
            catch (SocketException e)
            {
                output = "SocketException: " + e.ToString();
                System.Windows.Forms.MessageBox.Show(output);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtTypeMessageHere.Text);

            //socket.Send(sendingMessage);
            sendingMessage = System.Text.Encoding.ASCII.GetBytes(txtTypeMessageHere.Text);
            stream = client.GetStream();
            stream.Write(sendingMessage, 0, sendingMessage.Length);


            MessageBox.Items.Add("Me : " + txtTypeMessageHere.Text);
            txtTypeMessageHere.Text = "";

        }
    }
}