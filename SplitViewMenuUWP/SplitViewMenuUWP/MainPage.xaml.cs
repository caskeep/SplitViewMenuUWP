using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SplitViewMenu;
using SplitViewMenuUWP.Scenario1;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SplitViewMenuUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var mainViewModel = new MainViewModel();
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem { Label = "Page 1", DestinationPage = typeof(Scenario1Page1), Symbol = Symbol.Bookmarks});
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem { Label = "Page 2", DestinationPage = typeof(Scenario1Page2), Symbol = Symbol.Emoji});
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem { Label = "Page 3", DestinationPage = typeof(Scenario1Page3), Symbol = Symbol.RotateCamera});
            DataContext = mainViewModel;
        }
    }
}
