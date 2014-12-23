using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;
using Faker.Locales;

namespace Faker.Random
{
    internal class RandomFactory
    {
        private Object obj;
        private LocaleType localeType;
        private const string propertyName = "propertyName";
        private const string methodName = "methodName";

        // Might have some other better way to do it
        // For better performance and memory usage
        private Dictionary<string, FakerBase> fakerDictionary;
        
        internal RandomFactory(Object obj, LocaleType type)
        {
            this.obj = obj;
            this.localeType = type;
            this.fakerDictionary = new Dictionary<string, FakerBase>();
        }

        internal string Next<T>(string format, FormatType type = FormatType.Other)
        {
            return FillInRandomData<T>(format, this.obj, type);
        }

        internal string FillInRandomData<T>(string format,  Object obj, FormatType type = FormatType.Other)
        {
            if (type == FormatType.Other)
            {
                string result = format;
                string pattern = @"\#\{(?<" + propertyName + @">\w+)\}";
                return FillInRandomDataFromProperty<T>(format, obj, ref result, pattern);
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

        private string FillInRandomDataFromProperty<T>(string format, Object obj, ref string result, string pattern)
        {
            var matches = Regex.Matches(format, pattern);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string name = match.Groups[propertyName].Value;
                    string replacePattern = string.Concat("#{", name, "}");
                    result = Regex.Replace(result, replacePattern, GetRandomItemFromProperty<T>(name, obj).ToString());
                }
            }
            return FillInRandomDataFromNumber(result); // replace the special # symbol wih random number
        }

        internal string FillInRandomDataFromMethod(string format)
        {
            string result = format;
            string pattern = @"\@\{(?<" + methodName + @">[A-Za-z.]+)\}";
            var matches = Regex.Matches(format, pattern);
            if(matches.Count > 0)
            {
                foreach(Match match in matches)
                {
                    string fullNameSpaces = match.Groups[methodName].Value;
                    string replacePattern = string.Concat("@{", fullNameSpaces, "}");
                    string[] names = fullNameSpaces.Split('.');
                    string[] namespaceArray = new string[names.Length - 1];
                    Array.Copy(names, namespaceArray, names.Length - 1);
                    string nameSpace = string.Join(".", namespaceArray);
                    string methodname = names[names.Length - 1];
                    FakerBase faker = this.GetFakerObjectFromName(nameSpace);
                    result = Regex.Replace(result, replacePattern, GetRandomItemFromMethod<string>(methodname, faker));
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

        internal FakerBase GetFakerObjectFromName(string name)
        {
            if (this.fakerDictionary.ContainsKey(name))
            {
                return this.fakerDictionary[name];
            }
            else
            {
                // If it is the first time, create the FakerBase and add it to the dictionary
                Type t = Assembly.GetExecutingAssembly().GetType("Faker." + name);
                FakerBase faker = Activator.CreateInstance(t, new object[] { this.localeType }) as FakerBase;
                this.fakerDictionary.Add(name, faker);
                return faker;
            }
        }

        private T GetRandomItemFromMethod<T>(string methodName, FakerBase obj)
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
