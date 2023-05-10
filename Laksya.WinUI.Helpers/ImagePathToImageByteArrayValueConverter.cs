using Microsoft.UI.Xaml.Data;
using System;
using System.IO;

namespace Laksya.WinUI.Helpers;

public class ImagePathToImageByteArrayValueConverter : IValueConverter
{
    public object? Convert(object value, Type targetType, object parameter, string language)
    {
        if (value == null) return null;

        if (value is string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryReader reader = new BinaryReader(fileStream);

            byte[] binaryData = reader.ReadBytes(System.Convert.ToInt32(reader.BaseStream.Length - 1));
            reader.Close();

            return binaryData;
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}