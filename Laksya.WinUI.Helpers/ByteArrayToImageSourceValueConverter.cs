using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media.Imaging;
using System;
using System.IO;

namespace Laksya.WinUI.Helpers;

public class ByteArrayToImageSourceValueConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is null) return null;

        if (value is byte[] binaryData)
        {
            BitmapImage bitmapImage = new BitmapImage();
            byte[] bytes = (byte[])binaryData;

            using MemoryStream memoryStream = new MemoryStream(bytes);
            memoryStream.Position = 0;
            bitmapImage.SetSource(memoryStream.AsRandomAccessStream());

            return bitmapImage;
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}