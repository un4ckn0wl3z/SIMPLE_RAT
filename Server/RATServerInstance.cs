
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal static class RATServerInstance
    {
        public const string Version = "v1.0.0.0";
        public static Server.Networking.Server Server;

        static RATServerInstance()
        {
            Server = new Server.Networking.Server();
        }

        public static bool Listen(int port)
        {
            return Server.Listen(port);
        }

        // todo: RATServerInstance.StopListening();
    }
}
