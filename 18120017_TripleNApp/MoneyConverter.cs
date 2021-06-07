using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _18120017_TripleNApp
{
    public class MoneyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var c = value.ToString();
            var tmp = 0;
            var res = "";
            for (int i = c.Length - 1; i >= 0; i--)
            {
                tmp++;
                res = c[i] + res;
                if (tmp % 3 == 0 && i > 0) res = ',' + res;
            }
            return $"{res} đồng";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
