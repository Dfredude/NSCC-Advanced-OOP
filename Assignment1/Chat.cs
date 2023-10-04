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
        private String server_address = "localhost";
        private int port = 13000;
        readonly Messenger messenger;
        public Chat()
        {
            InitializeComponent();
            messenger = new Messenger(server_address, port);
            messenger.OnMessageReceivedEventHandler += onMessageReceived;
        }

        private void networkConnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connect clicked");
        }


        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Send message clicked");
            messenger.SendMessage(inputBox.Text);
        }

        public void onMessageReceived(string msg)
        {
            Console.WriteLine("Message received: " + msg);
            conversationPane.Items.Add(msg);
        }
    }
}
