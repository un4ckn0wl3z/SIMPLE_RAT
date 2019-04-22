using Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking
{
    class Server : IDisposable
    {
        public event EventHandler<bool> ServerStateChanged; // event server
        public event EventHandler<bool> ClientStateChanged; // evant client 
        public event EventHandler<IPacket> ClientMessageReceived; //

        // define socket
        private Socket socket;



        public bool Listen(int port)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            socket = new Socket(endPoint.AddressFamily,SocketType.Stream,ProtocolType.Tcp);


            return false;


        }


        public void Dispose()
        {
            socket.Shutdown(SocketShutdown.Both); // dispose socket
            socket.Close(); // close socket
        }
    }
}
