using System;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace PA.PersianUtils.ImageUtils
{
    public class DrawingImageToMediaImageConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Image)value).Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            System.Windows.Media.Imaging.BitmapImage bImg = new System.Windows.Media.Imaging.BitmapImage();

            bImg.BeginInit();

            bImg.StreamSource = new MemoryStream(ms.ToArray());

            bImg.EndInit();

            return bImg;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;
            if (value is BitmapSource)
            {
                MemoryStream TransportStream = new MemoryStream();
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)value));
                enc.Save(TransportStream);
                return new System.Drawing.Bitmap(TransportStream);
            }
            else
            {
                return value;
            }
        }
    }
}
