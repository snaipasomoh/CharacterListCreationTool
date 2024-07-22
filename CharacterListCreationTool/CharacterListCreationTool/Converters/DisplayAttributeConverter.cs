using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using CharacterListCreationTool.Helpers;
using CharacterListCreationTool.Lang;

namespace CharacterListCreationTool.Converters
{
    public class DisplayAttributeConverter : MarkupExtension, IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            var name = ((Enum)value).GetAttributeOfType<DisplayAttribute>().Name;
            var rType = ((Enum)value).GetAttributeOfType<DisplayAttribute>().ResourceType;
            var prop = rType?.GetProperty(name);
            return prop.GetValue(prop);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
