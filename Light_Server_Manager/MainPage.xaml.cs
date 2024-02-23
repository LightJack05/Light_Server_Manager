using Light_Server_Manager.Datamanagement.Types;

namespace Light_Server_Manager;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void frmMain_Loaded(object sender, RoutedEventArgs e)
    {
        frmMain.Navigate(typeof(Pages.QuickAccessPage));

        Server newServer = new Server("Foo", "foo", "127.0.0.1");
        //TODO make event fire on this line.
        newServer.PortAssociations.Add(new PortAssociation("ssh", 22));

        newServer.PortAssociations.RemoveAt(0);
    }
}
