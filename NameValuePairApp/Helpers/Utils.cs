using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NameValuePairApp.Helpers
{
    public static class Utils
    {
        public static bool IsAlphaNumeric(this string s)
        {
            bool b = Regex.IsMatch(s, "^[a-zA-Z0-9]+$");
            return b;
        }
    }
}
