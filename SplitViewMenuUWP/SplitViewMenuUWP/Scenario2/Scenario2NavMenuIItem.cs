using System;
using Windows.UI.Xaml.Controls;
using SplitViewMenu;

namespace SplitViewMenuUWP.Scenario2
{
    public class Scenario2NavMenuIItem : INavigationMenuItem
    {
        public int Symbol { get; set; }
        public char SymbolAsChar => (char)this.Symbol;
        public FontFamily FontFamilySymbol { get; set; }
        public string Label { get; set; }
        public object Arguments { get; set; }
        public Type DestinationPage { get; set; }
        public int NotifyCount { get; set; }
    }
}