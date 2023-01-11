using System;
using System.Windows.Data;

namespace PA.PersianUtils.ImageUtils
{
    public class DrawingColorToMediaColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
            System.Drawing.Color color = (System.Drawing.Color)value;
            System.Windows.Media.Color result = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
            return result;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
            System.Windows.Media.Color color = (System.Windows.Media.Color)value;
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    public class ArgbColorToMediaColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
            System.Drawing.Color color = System.Drawing.Color.FromArgb((int)value);
            System.Windows.Media.Color result = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
            return result;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
            System.Windows.Media.Color color = (System.Windows.Media.Color)value;
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B).ToArgb();
        }
    }
}
