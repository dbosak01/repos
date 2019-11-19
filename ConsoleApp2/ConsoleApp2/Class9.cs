using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp2
{
    class Class9
    {

        public static void Main()
        {

            //IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            IPAddress ip = Dns.GetHostAddresses("127.0.0.1")[0];
            TcpListener server = new TcpListener(ip, 6000);
            TcpClient client = default(TcpClient);


            try
            {

                server.Start();
                Console.WriteLine("Server started ...");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            while(true)
            {

                client = server.AcceptTcpClient();
                byte[] receivedBuffer = new byte[100];
                NetworkStream stream = client.GetStream();
                stream.Read(receivedBuffer, 0, receivedBuffer.Length);

                string msg = Encoding.ASCII.GetString(receivedBuffer);




                Console.WriteLine(msg);

            }
            
        }
    }
}
