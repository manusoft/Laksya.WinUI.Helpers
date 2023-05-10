using Microsoft.UI.Xaml.Data;
using System;

namespace Laksya.WinUI.Helpers;

public class NullToBooleanValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if(value == null)
        {
            return false;
        }

        return true;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
