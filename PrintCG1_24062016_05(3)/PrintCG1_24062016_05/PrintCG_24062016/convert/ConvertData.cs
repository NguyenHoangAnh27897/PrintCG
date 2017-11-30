using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCG_24062016.convert
{
    public class ConvertData
    {
        public static string nullToString(object value)
        {
            try
            {
                if (value == null) return string.Empty;
                return value.ToString();
            }catch
            {
                value = string.Empty;
                return value.ToString();
            }
            
        }
        public static int ToInt32(object value)
        {
            if (value == null)
            {
                return 0;
            }
            else
            {
                return ((IConvertible)value).ToInt32(null);
            }
        }
    }
}
