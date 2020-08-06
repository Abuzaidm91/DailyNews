using DailyNews.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace DailyNews.Converters
{
    class ConvertToEeasternNumbers : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime dateTime = (DateTime)value;
                return ConvertToEasternNum.ConvertToEasternArabicNumerals(dateTime.ToString("yyyy/MM/dd hh:mm tt",new CultureInfo("ar-JO")));
            }
            return ConvertToEasternNum.ConvertToEasternArabicNumerals(value.ToString()); ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
