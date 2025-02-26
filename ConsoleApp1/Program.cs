using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
class ChatServer
{
    private static Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
    private static Dictionary<string, List<string>> rooms = new Dictionary<string, List<string>>();
    private static Dictionary<string, DateTime> bannedUsers = new Dictionary<string, DateTime>();
    private static string adminPassword = "admin123";
    private static List<string> forbiddenWords = new List<string> { "badword1", "badword2", "badword3" };
    private static TcpClient adminClient = null;
    static void Main(string[] args)
    {
        TcpListener server = new TcpListener(IPAddress.Any, 8888);
        server.Start();
        Console.WriteLine("Сервер запущен...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Thread clientThread = new Thread(() => HandleClient(client));
            clientThread.Start();
        }
    }
    private static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead;
        string username = "";

        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            string[] parts = message.Split('|');

            if (parts[0] == "REGISTER")
            {
                username = parts[1];
                if (bannedUsers.ContainsKey(username) && bannedUsers[username] > DateTime.Now)
                {
                    byte[] banMessage = Encoding.UTF8.GetBytes("BANNED|Вы заблокированы до " + bannedUsers[username]);
                    stream.Write(banMessage, 0, banMessage.Length);
                    client.Close();
                    return;
                }
                clients[username] = client;
                Console.WriteLine($"{username} подключился.");
            }
            else if (parts[0] == "CREATE_ROOM")
            {
                string roomName = parts[1];
                rooms[roomName] = new List<string> { username };
                Console.WriteLine($"{username} создал комнату {roomName}.");
            }
            else if (parts[0] == "JOIN_ROOM")
            {
                string roomName = parts[1];
                if (rooms.ContainsKey(roomName))
                {
                    rooms[roomName].Add(username);
                    Console.WriteLine($"{username} присоединился к комнате {roomName}.");
                }
            }
            else if (parts[0] == "ROOM_MESSAGE")
            {
                string roomName = parts[1];
                string msg = parts[2];
                string censoredMsg = CensorMessage(msg);
                if (censoredMsg != msg)
                {
                    NotifyAdmin($"{username} отправил запрещенное слово: {msg}");
                }
                SendRoomMessage(roomName, $"{username}: {censoredMsg}");
            }
            else if (parts[0] == "ADMIN_LOGIN")
            {
                string password = parts[1];
                if (password == adminPassword)
                {
                    adminClient = client;
                    byte[] adminMessage = Encoding.UTF8.GetBytes("ADMIN|Вы вошли как администратор.");
                    stream.Write(adminMessage, 0, adminMessage.Length);
                    HandleAdminCommands(stream);
                }
                else
                {
                    byte[] errorMessage = Encoding.UTF8.GetBytes("ADMIN|Неверный пароль.");
                    stream.Write(errorMessage, 0, errorMessage.Length);
                }
            }
        }
    }
    private static string CensorMessage(string message)
    {
        foreach (var word in forbiddenWords)
        {
            if (message.Contains(word))
            {
                message = message.Replace(word, "###");
            }
        }
        return message;
    }
    private static void NotifyAdmin(string message)
    {
        if (adminClient != null)
        {
            NetworkStream adminStream = adminClient.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes($"ADMIN_NOTIFY|{message}");
            adminStream.Write(buffer, 0, buffer.Length);
        }
    }
    private static void HandleAdminCommands(NetworkStream stream)
    {
        byte[] buffer = new byte[1024];
        int bytesRead;

        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            string[] parts = message.Split('|');

            if (parts[0] == "BAN_USER")
            {
                string username = parts[1];
                int minutes = int.Parse(parts[2]);
                if (clients.ContainsKey(username))
                {
                    bannedUsers[username] = DateTime.Now.AddMinutes(minutes);
                    byte[] banMessage = Encoding.UTF8.GetBytes($"BANNED|Вы заблокированы до {bannedUsers[username]}");
                    NetworkStream userStream = clients[username].GetStream();
                    userStream.Write(banMessage, 0, banMessage.Length);
                    clients[username].Close();
                    clients.Remove(username);
                    Console.WriteLine($"{username} заблокирован на {minutes} минут.");
                }
            }
            else if (parts[0] == "DELETE_USER")
            {
                string username = parts[1];
                if (clients.ContainsKey(username))
                {
                    clients[username].Close();
                    clients.Remove(username);
                    Console.WriteLine($"{username} удален из чата.");
                }
            }
        }
    }
    private static void SendRoomMessage(string roomName, string message)
    {
        if (rooms.ContainsKey(roomName))
        {
            foreach (var user in rooms[roomName])
            {
                if (clients.ContainsKey(user))
                {
                    TcpClient client = clients[user];
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}