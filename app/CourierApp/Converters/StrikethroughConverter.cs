using System.Globalization;

namespace CourierApp.Converters;

/// <summary>True (e.g. a cancelled stop) → struck-through text.</summary>
public class StrikethroughConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        value is true ? TextDecorations.Strikethrough : TextDecorations.None;

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
