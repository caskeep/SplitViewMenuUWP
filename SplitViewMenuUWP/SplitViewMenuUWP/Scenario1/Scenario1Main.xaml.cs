using Windows.UI.Xaml.Controls;
using SplitViewMenu;

namespace SplitViewMenuUWP.Scenario1
{
    public sealed partial class Scenario1Main
    {
        public Scenario1Main()
        {
            InitializeComponent();
            var mainViewModel = new Scenario1ViewModel();
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 1",
                DestinationPage = typeof (Scenario1Page1),
                FontFamilySymbol = SplitViewMenu.FontFamily.FontAwesome,
                Symbol = (int)FontAwesome.fa_money
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 2",
                DestinationPage = typeof(Scenario1Page2),
                Symbol = (int)Symbol.Emoji
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Page 3",
                DestinationPage = typeof(Scenario1Page3),
                Symbol = (int)Symbol.RotateCamera
            });
            DataContext = mainViewModel;
        }
    }
}