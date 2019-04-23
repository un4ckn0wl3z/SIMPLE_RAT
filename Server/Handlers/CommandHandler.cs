using Server.Networking;
using Server.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Handlers
{
    public partial class CommandHandler
    {
        public static void HandleCommand(ClientNode client, IdentificationPacket packet)
        {
            Console.WriteLine(client.GetClientIdentifier() + " identified as " + packet.Name + " and is running " + packet.OperatingSystem);
        }

        public static void HandleCommand(ClientNode client, StringMessagePacket packet)
        {
            Console.WriteLine(packet.Message);
        }
    }
}