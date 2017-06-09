#region Usings

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

#endregion

namespace VkMirea.Converters
{
    public abstract class BaseConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        public abstract object Convert(object value, Type targetType, object parameter,
                                       CultureInfo culture);

        public virtual object ConvertBack(object value, Type targetType, object parameter,
                                          CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #region MarkupExtension members

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _converter ?? (_converter = new T());
        }

        private static T _converter;

        #endregion
    }
}