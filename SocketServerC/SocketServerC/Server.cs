using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SocketServerC
{
    class Server
    {
            static UnicodeEncoding encoding = new UnicodeEncoding();
            static Socket listeningSocket = null;
            static Socket socket = null;
            const Int32 BUFFERLENGTH = 80;

            public void SocketServer(string ip, int port)
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);
                try
                {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listeningSocket.Bind(localEndPoint);
                listeningSocket.Listen(1);

                //Found a connection
                socket = listeningSocket.Accept();

                Byte[] buffer = new Byte[BUFFERLENGTH];
                socket.Receive(buffer);
                //Skriva kod för vad som ska hända med det som kommer från klienten (message)
                String message = encoding.GetString(buffer);

                Arduino ard = new Arduino();
                ard.SendToArduino(message);
                
                Console.WriteLine("Received message: " + message);

                String response = "Finns";
                byte[] resp = encoding.GetBytes(response);
                socket.Send(resp);

                Console.ReadLine();

            }
                catch (Exception exception)
                {
                    Console.WriteLine("ERROR: " + exception.Message + "\n" + exception.StackTrace);
                    Console.ReadLine();
                }
                finally
                {
                    if (listeningSocket != null)
                        listeningSocket.Close();
                    if (socket != null)
                        socket.Close();
                }
            }
        }
}
