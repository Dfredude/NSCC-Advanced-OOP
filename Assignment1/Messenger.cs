using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Assignment1
{
    internal class Messenger
    {
        TcpClient client = new TcpClient();
        NetworkStream stream;
        bool connected = false;
        public delegate void MessageReceived(string msg);
        public event MessageReceived OnMessageReceivedEventHandler;
        public Messenger(String server, int port)
        {
            client.Connect(server, port);
            connected = true;
            stream = client.GetStream();
            //Thread messageListener = new Thread(ListenIncomingMessages);
            //messageListener.Start();
            // SendMessage("Hello from the Client");
        }
        public void Close()
        { 
            client.Close();
            stream.Close();
            connected = false;
        }

        //private void ListenIncomingMessages()
        //{
        //    while (connected)
        //    {
        //        if (stream.DataAvailable)
        //        {
        //            byte[] response = new byte[1024];
        //            int bytesRead = stream.Read(response, 0, response.Length);
        //            string msg = System.Text.Encoding.ASCII.GetString(response, 0, bytesRead);
        //            OnMessageReceivedEventHandler(msg);
        //        }
        //    }
        //}

        public string ReadMessage()
        {
            byte[] response = new byte[1024];
            int bytesRead = stream.Read(response, 0, response.Length);
            string msg = System.Text.Encoding.ASCII.GetString(response, 0, bytesRead);
            return msg;
        }

        public void SendMessage(string message)
        {
            // Send handshake
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(msg, 0, msg.Length);
            // Listen for response
            string response = ReadMessage();
            OnMessageReceivedEventHandler(response);
        }
    }
}
