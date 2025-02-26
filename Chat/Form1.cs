using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
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
            byte[] buffer = Encoding.UTF8.GetBytes($"Register|{username}");
            stream.Write(buffer,0,buffer.Length);
            Thread reciveThread = new Thread(ReceiveMessages);
            reciveThread.Start();
        }
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (message.StartsWith("BANNED|"))
                {
                    MessageBox.Show(message.Substring(7));
                    this.Close();
                    return;
                }
                else if (message.StartsWith("ADMIN_NOTIFY|"))
                {
                    AdminNotificationsTextBox.Invoke((MethodInvoker)delegate {
                        AdminNotificationsTextBox.AppendText(message.Substring(13) + Environment.NewLine);
                    });
                }
                else
                {
                    ChatTextBox.Invoke((MethodInvoker)delegate {
                        ChatTextBox.AppendText(message + Environment.NewLine);
                    });
                }
            }
        }
        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = RoomNameTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"CREATE_ROOM|{roomName}");
            stream.Write(buffer, 0, buffer.Length);
        }
        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = RoomNameTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"JOIN_ROOM|{roomName}");
            stream.Write(buffer, 0, buffer.Length);
        }
        private void SendRoomMessageButton_Click(object sender, EventArgs e)
        {
            string roomName = RoomNameTextBox.Text;
            string message = RoomMessageTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"ROOM_MESSAGE|{roomName}|{message}");
            stream.Write(buffer, 0, buffer.Length);
            RoomMessageTextBox.Clear();
        }
        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            string password = AdminPasswordTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"ADMIN_LOGIN|{password}");
            stream.Write(buffer, 0, buffer.Length);
        }
        private void BanUserButton_Click(object sender, EventArgs e)
        {
            string username = BanUsernameTextBox.Text;
            int minutes = (int)BanMinutesNumericUpDown.Value;
            byte[] buffer = Encoding.UTF8.GetBytes($"BAN_USER|{username}|{minutes}");
            stream.Write(buffer, 0, buffer.Length);
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string username = DeleteUsernameTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes($"DELETE_USER|{username}");
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}