using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MyWPFApp.Converters
{
    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value.ToString();
            if (status.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                return true;
            else
                return false;
                               
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (bool)value;

            if (status)
                return "Yes";
            else
                return "No";

        }
    }
}
