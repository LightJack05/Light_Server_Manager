using System.Collections.ObjectModel;
using Light_Server_Manager.Datamanagement.Types;
using Windows.ApplicationModel.DataTransfer;

namespace Light_Server_Manager.Datamanagement.DataStore;
internal class RamDataStore
{
    public static ObservableCollection<Server> Servers;
    public static ObservableCollection<PortForward> PortForwards;
    public static ObservableCollection<PortAssociation> PortAssociations;

    static RamDataStore()
    {
        Servers = new ObservableCollection<Server>();
        PortForwards = new ObservableCollection<PortForward>();
        PortAssociations = new ObservableCollection<PortAssociation>();
    }
}
