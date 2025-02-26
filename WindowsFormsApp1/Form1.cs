using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string username;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 8888);
            stream = client.GetStream();
            username = UsernameTextBox.Text;

            byte[] buffer = Encoding.UTF8.GetBytes($"REGISTER|{username}");
            stream.Write(buffer, 0, buffer.Length);

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                ChatTextBox.Invoke((MethodInvoker)delegate {
                    ChatTextBox.AppendText(message + Environment.NewLine);
                });
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"BROADCAST|{username}|{message}");
            stream.Write(buffer, 0, buffer.Length);
            MessageTextBox.Clear();
        }

        private void SendPrivateButton_Click(object sender, EventArgs e)
        {
            string toUser = PrivateUserTextBox.Text;
            string message = PrivateMessageTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"UNICAST|{username}|{toUser}|{message}");
            stream.Write(buffer, 0, buffer.Length);
            PrivateMessageTextBox.Clear();
        }
    }
}