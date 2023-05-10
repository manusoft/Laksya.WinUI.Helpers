using Microsoft.UI.Xaml.Data;
using System;

namespace Laksya.WinUI.Helpers;

public class ImagePathToImageSourceValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value == null) return null;

        if (value is string path)
        {
            var binaryData = new ImagePathToImageByteArrayValueConverter().Convert(path, targetType, parameter, language);

            return new ByteArrayToImageSourceValueConverter().Convert(binaryData, targetType, parameter, language);
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}