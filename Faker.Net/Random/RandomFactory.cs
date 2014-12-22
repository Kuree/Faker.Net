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
        private Object obj;
        private string format;
        private const string groupName = "propertyName";

        internal RandomFactory(string format, Object obj)
        {
            this.format = format;
            this.obj = obj;
        }

        internal string Next<T>(FormatType type = FormatType.Property)
        {
            return FillInRandomData<T>(this.format, this.obj, type);
        }

        internal string FillInRandomData<T>(string format,  Object obj, FormatType type = FormatType.Property)
        {
            string result = format;
            string pattern = type == FormatType.Property ? @"\#\{(?<" + groupName + @">\w+)\}" : ""; // Need to add number support
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(format);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string propertyName = match.Groups[groupName].Value;
                    string replacePattern = type == FormatType.Property? string.Concat("#{", propertyName, "}") : "";
                    result = Regex.Replace(result, replacePattern, GetRandomItemFromProperty<T>(propertyName, obj).ToString());
                }
            }
            return result;
        }

        internal T GetRandomItemFromProperty<T>(string propertyName, Object obj, int index = -1)
        {
            T result = default(T);
            Type type = obj.GetType();
            var property = type.GetProperties().FirstOrDefault(entry => entry.Name == propertyName);
            if(property != null)
            {
                var values = property.GetValue(obj) as IList<T>;
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
