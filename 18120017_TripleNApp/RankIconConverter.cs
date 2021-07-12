using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _18120017_TripleNApp
{
    public class RankIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var item = (int)value;
            switch (item)
            {
                case 1: return "ImagesResource/gold.png"; break;
                case 2: return "ImagesResource/silver.png"; break;
                case 3: return "ImagesResource/bronze.png"; break;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
