using System;
using System.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SplitViewMenu
{
    public sealed class EnumToFontFamilyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var e = (FontFamily)value;

            if (e.Equals(FontFamily.SegoeMDL2))
                return new Windows.UI.Xaml.Media.FontFamily("Segoe MDL2 Assets");

            return Application.Current.Resources["FontAwesomeFontFamily"] as Windows.UI.Xaml.Media.FontFamily;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

    }
}
