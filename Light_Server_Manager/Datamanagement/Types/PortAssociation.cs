using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Server_Manager.Datamanagement.Types;
internal class PortAssociation
{
    public string? Purpose { get; set; }
    public ushort Port { get; set; }
    public Server? ServerContext { get; set; }

    public PortAssociation(string? purpose, ushort port)
    {
        Purpose = purpose;
        Port = port;
    }

    public PortAssociation(string? purpose, ushort port, Server serverContext)
    {
        Purpose = purpose;
        Port = port;
        ServerContext = serverContext;
    }
}
