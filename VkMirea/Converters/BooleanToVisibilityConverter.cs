using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace VkMirea.Converters
{
    public class BooleanToVisibilityConverter : BaseConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool)) throw new NotSupportedException();

            if ((bool) value)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }
    }
}