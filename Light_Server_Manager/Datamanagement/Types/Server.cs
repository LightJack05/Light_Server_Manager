using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Server_Manager.Datamanagement.Types;
internal class Server
{
    public string? Name { get; set; }
    public string? Hostname { get; set; }
    public string? IpAddress { get; set; }

    public ObservableCollection<PortForward> PortForwards { get; private set; }
    public ObservableCollection<PortAssociation> PortAssociations { get; private set; }

    public Server(string? name, string? hostname, string? ipAddress, ObservableCollection<PortForward> portForwards, ObservableCollection<PortAssociation> portAssociations)
    {
        Name = name;
        Hostname = hostname;
        IpAddress = ipAddress;
        PortForwards = portForwards;
        PortAssociations = portAssociations;

        PortAssociations.CollectionChanged += OnPortAssociationsUpdated;
    }
    public Server(string? name, string? hostname, string? ipAddress)
    {
        Name = name;
        Hostname = hostname;
        IpAddress = ipAddress;
        PortForwards = new();
        PortAssociations = new();
    }


    private void OnPortAssociationsUpdated(object? sender, NotifyCollectionChangedEventArgs e)
    {
        foreach (PortAssociation portAssociation in e.NewItems)
        {
            if (portAssociation.ServerContext == null)
            {
                portAssociation.ServerContext = this;
            }
        }
        foreach (PortAssociation portAssociation in e.OldItems)
        {
            if (portAssociation.ServerContext == this && !PortAssociations.Contains(portAssociation))
            { 
                portAssociation.ServerContext = null; 
            }
        }
    }
}