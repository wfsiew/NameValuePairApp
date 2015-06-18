using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NameValuePairApp.Helpers
{
    public static class Utils
    {
        /// <summary>
        /// This extension method checks the input string contains only alphanumeric
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>True if is alphanumeric, False otherwise</returns>
        public static bool IsAlphaNumeric(this string s)
        {
            bool b = Regex.IsMatch(s, "^[a-zA-Z0-9]+$", RegexOptions.Compiled);
            return b;
        }
    }
}
