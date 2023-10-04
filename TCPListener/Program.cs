using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//DEFINITIONS:
//Def of IP "Internet Protocol," which is the set of rules governing the format of data sent via the internet or local network.
//Def of IP Address - An IP address is a unique address that identifies a device on the internet or a local network.
//Def of TCP https://www.techtarget.com/searchnetworking/definition/TCP
//Def of Socket https://www.easytechjunkie.com/what-is-a-tcpip-socket.htm
//Def of Port https://www.cbtnuggets.com/blog/technology/networking/what-is-a-tcp-port-and-why-they-are-important
//Def of Blocking Call https://www.ibm.com/docs/en/zos/2.2.0?topic=otap-clientserver-socket-programs-blocking-nonblocking - asynchronous - socket - calls
//Def of Tasks https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=net-7.0

namespace TCPListener
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;

            try
            {
                // Starting server
                Int32 port = 13000;
                IPAddress localAddress = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddress, port);
                server.Start();

                // Set up buffer for reading data
                Byte[] buffer = new Byte[256];
                String data = null;

                // Enter the listening loop
                while (true)
                {
                    Console.WriteLine("Waiting for connection...");

                    // Perform a blocking call to accept requests
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected");

                    data = null;

                    NetworkStream stream = client.GetStream();

                    int i;
                    while ((i = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        // Translate data bytes to an ASCII string
                        data = System.Text.Encoding.ASCII.GetString(buffer, 0, i);
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // send back responses

                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);

                    }
                    client.Close();
                }

            } catch (SocketException e)
            {
                Console.WriteLine("Socket Exception: {0}", e.ToString());
            } finally
            {
                // Stop listening
                server.Stop();
            }
        }
    }
}
