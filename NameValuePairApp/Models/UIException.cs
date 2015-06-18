using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameValuePairApp.Models
{
    public class UIException : Exception
    {
        public UIException(string message) : base(message)
        {
        }
    }
}
