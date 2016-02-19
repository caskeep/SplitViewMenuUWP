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
                Symbol = "&#xf0d6;"
            });
            //mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            //{
            //    Label = "Page 2",
            //    DestinationPage = typeof (Scenario1Page2),
            //    Symbol = Symbol.Emoji
            //});
            //mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            //{
            //    Label = "Page 3",
            //    DestinationPage = typeof (Scenario1Page3),
            //    Symbol = Symbol.RotateCamera
            //});
            DataContext = mainViewModel;
        }
    }
}