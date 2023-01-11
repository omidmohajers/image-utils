using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PA.PersianUtils.ImageUtils
{
    public class BitmapToBitmapSourceConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            System.Drawing.Bitmap source = value as System.Drawing.Bitmap;
            if (source == null || targetType != typeof(ImageSource))
                return null;
            return ImageUtils.Imaging.ConvertBitmapToBitmapImage(source);


        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
        #endregion
    }
}
