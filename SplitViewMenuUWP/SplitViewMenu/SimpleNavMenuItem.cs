using System;
using Windows.UI.Xaml.Controls;

namespace SplitViewMenu
{
    public sealed class SimpleNavMenuItem : INavigationMenuItem
    {
        public SimpleNavMenuItem()
        {
            FontFamilySymbol = FontFamily.SegoeMDL2;
        }

        public string Label { get; set; }
        public int Symbol { get; set; }
        public char SymbolAsChar => (char)this.Symbol;
        public FontFamily FontFamilySymbol { get; set; }
        public object Arguments { get; set; }
        public Type DestinationPage { get; set; }
    }
}