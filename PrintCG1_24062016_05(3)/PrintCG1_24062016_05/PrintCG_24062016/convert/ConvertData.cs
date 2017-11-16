using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCG_24062016.convert
{
    public class ConvertData
    {
        public static string nullToString(string value)
        {
            if(value == null) return string.Empty;
            return value;
        }
    }
}
