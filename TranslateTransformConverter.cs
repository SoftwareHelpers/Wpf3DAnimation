using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf3DAnimation
{
    using System.Globalization;
    using System.Windows.Data;

    public class TranslateTransformConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return 0;
            }

            var seconds = System.Convert.ToInt32(value);
            var miliseconds = System.Convert.ToInt32((System.Convert.ToDouble(value, CultureInfo.InstalledUICulture) % 1) * 100);
            var newValue = new System.Windows.Duration(new TimeSpan(0, 0, seconds, miliseconds)); //// System.Convert.ToDouble(value);
            return newValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}
