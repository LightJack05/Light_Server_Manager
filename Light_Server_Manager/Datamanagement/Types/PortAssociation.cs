using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Server_Manager.Datamanagement.Types;
internal class PortAssociation : IDisposable
{
    public string? Purpose { get; set; }
    public ushort Port { get; set; }
    public Server? ServerContext { get; set; }

    public PortAssociation(string? purpose, ushort port)
    {
        Purpose = purpose;
        Port = port;

        DataStore.RamDataStore.PortAssociations.Add(this);
    }

    public PortAssociation(string? purpose, ushort port, Server serverContext)
    {
        Purpose = purpose;
        Port = port;
        ServerContext = serverContext;

        DataStore.RamDataStore.PortAssociations.Add(this);
    }

    public void Dispose()
    {
        DataStore.RamDataStore.PortAssociations.Remove(this);
    }
}
