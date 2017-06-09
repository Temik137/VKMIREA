using System;
using System.Globalization;
using System.Windows.Data;
using VkMirea.AppContext;

namespace VkMirea.Converters
{
    public class StringToAppModeStateConverter : BaseConverter<StringToAppModeStateConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value?.ToString())
            {
                case "Training":
                    return ModeState.Training;
                case "Examine":
                    return ModeState.Examine;
                default:
                    return ModeState.None;
            }
        }
    }
}