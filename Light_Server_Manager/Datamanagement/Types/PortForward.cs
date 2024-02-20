using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Server_Manager.Datamanagement.Types;
internal class PortForward
{
    public string Purpose { get; set; }
    public Server? ForwardingServer { get; set; }
    public ushort PortIn { get; set; }
    public Server? TargetServer { get; set; }
    public ushort PortOnTargetServer { get; set; }

    public PortForward(string purpose, ushort portIn, ushort portOnTargetServer)
    {
        Purpose = purpose;
        PortIn = portIn;
        PortOnTargetServer = portOnTargetServer;
    }
    public PortForward(string purpose, ushort portIn, ushort portOnTargetServer, Server forwardingServer, Server targetServer ) 
    {
        Purpose = purpose;
        PortIn = portIn;
        PortOnTargetServer = portOnTargetServer;
        ForwardingServer = forwardingServer;
        TargetServer = targetServer;
    }


}
