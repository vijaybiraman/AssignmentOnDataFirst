using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CodeFirstAssignment
{
    public class ValueConverter :IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            decimal NetStock = 0;
            if (values[0] != null && values[1]!=null)
            {
            
                decimal NetStock1 = (decimal)(values[0]);
              short  NetStock2 = (short)values[1];
                NetStock = NetStock1 * NetStock2;
                return NetStock.ToString(parameter as string, culture);
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
