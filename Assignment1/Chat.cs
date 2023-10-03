using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Chat : Form
    {
        String server = "localhost";
        int port = 13000;
        Thread serverCommunication;
        TcpClient client = new TcpClient();
        public Chat()
        {
            InitializeComponent();
            serverCommunication = new Thread(() => ConnectToServer(server, port));
            serverCommunication.Start();
            serverCommunication.IsBackground = true;
        }

        async void SendMessage(string message)
        {
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            await client.GetStream().WriteAsync(data, 0, data.Length);
            Console.WriteLine("Sent: {0}", message);

            // Get response
            data = new Byte[256];
            String responseData = String.Empty;
        }

        private void ConnectToServer(String server, int port)
        {
            client.Connect(server, port);

            NetworkStream stream = client.GetStream();

            byte[] message = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = stream.Read(message, 0, message.Length);
                Console.WriteLine(Encoding.ASCII.GetString(message, 0, bytesRead));
            }
            client.Close();
            stream.Close();


        }

        private void networkConnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connect clicked");
        }


        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Send message clicked");
            SendMessage(inputBox.Text);
        }
    }
}
