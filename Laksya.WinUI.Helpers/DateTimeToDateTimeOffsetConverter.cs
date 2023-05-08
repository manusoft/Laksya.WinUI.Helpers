using Microsoft.UI.Xaml.Data;
using System;

namespace Laksya.WinUI.Helpers;

public class DateTimeToDateTimeOffsetConverter : IValueConverter
{
    // Convert DateTime to DateTimeOffset
    public object? Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is null) return null;

        DateTime? datetime = (DateTime)value;

        return new DateTimeOffset(datetime.Value);
    }

    // Convert DateTimeOffset to DateTime
    public object? ConvertBack(object value, Type targetType, object parameter, string language)
    {
        if (value is null) return null;

        DateTimeOffset? datetimeoffset = (DateTimeOffset)value;

        return datetimeoffset.Value.LocalDateTime;
    }
}