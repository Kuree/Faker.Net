using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;

namespace Faker.Net.Random
{
    internal class RandomFactory
    {
        private string[] propertyNames;
        private Object obj;
        private string format;
        private const string groupName = "propertyName";

        internal RandomFactory(string format, Object obj)
        {
            this.propertyNames = this.ReadReadFormat(format);
            this.format = format;
            this.obj = obj;
        }

        internal string[] ReadReadFormat(string format, FormatType type = FormatType.Property)
        {
            string pattern = type == FormatType.Property? @"\#\{(?<" + groupName + @">\w+)\}" : ""; // Need to add number support
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(format);
            List<string> result = new List<string>();
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string propertyName = match.Groups[groupName].Value;
                    result.Add(propertyName);
                }
            }
            return result.ToArray();
        }

        internal string Next()
        {
            return "";
        }

        internal T GetRandomItemFromProperty<T>(string propertyName, int index = -1)
        {
            T result = default(T);
            Type type = this.obj.GetType();
            var property = type.GetProperties().First(entry => entry.Name == propertyName);
            if(property != null)
            {
                var values = property.GetValue(this.obj) as IList<T>;
                if (values != null)
                    return index == -1? Random.Selector.GetRandomItemFromList<T>(values) : values[index];
            }
            return result;
        }
    }

    public enum FormatType
    {
        Number,
        Property
    }
}
