using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DailyNews.Converters
{
    class ConverterToBitImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) { return ""; }
            if (String.IsNullOrEmpty(value.ToString())) { return ""; }
            BitmapImage _viewImage = new BitmapImage();
            _viewImage.BeginInit();
            _viewImage.CacheOption = BitmapCacheOption.OnLoad;
            _viewImage.UriSource = new Uri(value.ToString());
            _viewImage.EndInit();
            return _viewImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
