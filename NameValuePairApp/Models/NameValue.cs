using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameValuePairApp.Models
{
    public class NameValue
    {
        public NameValue(string key, string value)
        {
            Name = key;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0}={1}", Name, Value);
        }
    }

    /// <summary>
    /// Sort Direction
    /// </summary>
    public enum SortDir
    {
        DEFAULT = 0,
        ASC = 1,
        DESC = 2
    }

    /// <summary>
    /// Sort Field
    /// </summary>
    public enum SortField
    {
        DEFAULT = 0,
        NAME = 1,
        VALUE = 2
    }
}
