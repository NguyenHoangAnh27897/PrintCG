using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCG_24062016.API
{
    public class DateMethods
    {
        private static String ISO8601Short = "yyyy'-'MM'-'dd'T'HH':'mm':'sszzz";


        public static String ToString(DateTime date)
        {
            // since we pass it to UniversalTime we can add the +00:00 manually
            return date.ToString(ISO8601Short);

        }
    }
}
