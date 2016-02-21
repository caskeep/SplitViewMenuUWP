using Windows.UI.Xaml.Controls;
using SplitViewMenu;

namespace SplitViewMenuUWP.Scenario3
{
    public sealed partial class Scenario3Main : Page
    {
        public Scenario3Main()
        {
            InitializeComponent();
            var mainViewModel = new Scenario3ViewModel();
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 1",
                DestinationPage = typeof (Scenario3Page1),
                Symbol = (int)Symbol.Bookmarks
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 2",
                DestinationPage = typeof (Scenario3Page2),
                Symbol = (int)Symbol.Emoji
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 3",
                DestinationPage = typeof (Scenario3Page3),
                Symbol = (int)Symbol.RotateCamera
            });
            DataContext = mainViewModel;
        }
    }
}