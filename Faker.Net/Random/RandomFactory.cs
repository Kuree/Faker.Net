using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;

namespace Faker.Random
{
    internal class RandomFactory
    {
        private Object obj;
        private const string groupName = "propertyName";
        private const string methodName = "methodName";
        
        internal RandomFactory(Object obj)
        {
            this.obj = obj;
        }

        internal string Next<T>(string format, FormatType type = FormatType.Other)
        {
            return FillInRandomData<T>(format, this.obj, type);
        }

        private string FillInRandomData<T>(string format,  Object obj, FormatType type = FormatType.Other)
        {
            if (type == FormatType.Other)
            {
                string result = format;
                string pattern = @"\#\{(?<" + groupName + @">\w+)\}";
                return FillInRandomDataFromProperty<T>(format, obj, type, ref result, pattern);
            }
            else
            {
                return this.FillInRandomDataFromNumber(format);
            }
        }

        private string FillInRandomDataFromNumber(string format, char symbol = '#')
        {
            var result = format.ToCharArray();
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] == symbol)
                    result[i] = (char)Random.RandomProxy.Next(10);
            }
            return new string(result);
        }

        private string FillInRandomDataFromProperty<T>(string format, Object obj, FormatType type, ref string result, string pattern)
        {
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(format);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string propertyName = match.Groups[groupName].Value;
                    string replacePattern = type == FormatType.Other ? string.Concat("#{", propertyName, "}") : "";
                    result = Regex.Replace(result, replacePattern, GetRandomItemFromProperty<T>(propertyName, obj).ToString());
                }
            }
            return FillInRandomDataFromNumber(result); // replace the special # symbol wih random number
        }

        private T GetRandomItemFromProperty<T>(string propertyName, Object obj, int index = -1)
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

        private T GetRandomItemFromMethod<T>(string methodName, Object obj)
        {
            Type type = obj.GetType();
            var method = type.GetMethod(methodName);
            return (T)method.Invoke(obj, null);
        }
    }

    public enum FormatType
    {
        Number,
        Other
    }
}
