// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using System.Collections.ObjectModel;

namespace Light_Server_Manager.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class QuickAccessPage : Page
{

    private ObservableCollection<Object> _displayedObjects = new();
    public QuickAccessPage()
    {
        this.InitializeComponent();
    }

    private void asbMainSearch_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        
    }
}
