using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRLamb.StringUtils
{
    public static class Utils
    {
        public static string TrimInnerWhitespace(this string str)
        {
            str = str.Trim();
            int index;
            index = str.IndexOf("  ");
            if (index < 0)
                return str;
            else
                return (str.Substring(0, index + 1) + str.Substring(index + 2)).TrimInnerWhitespace();
         }

        public static bool IsNullOrWhitespace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
       
    }
}
