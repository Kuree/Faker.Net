using System;
using System.Collections.Generic;
using System.Reflection;

namespace Faker.Locales
{
    internal class LocaleFactory
    {
        internal static Locale Create(LocaleType localType)
        {
            foreach(var type in Assembly.GetExecutingAssembly().GetTypes())
            { 
                if (type.BaseType == typeof(Locale) || type.BaseType == typeof(En))
                {
                    var attr = Attribute.GetCustomAttribute(type, typeof(LocaleAttribute)) as LocaleAttribute;
                    if(attr != null && attr.LocaleType == localType)
                    {
                        return Activator.CreateInstance(type) as Locale;
                    }
                }
            }
            return null;
        }

        internal static LocaleType[] GetAvailableLocales()
        {
            List<LocaleType> list = new List<LocaleType>();
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.BaseType == typeof(En) || type.BaseType == typeof(Locale))
                {
                    var attr = Attribute.GetCustomAttribute(type, typeof(LocaleAttribute)) as LocaleAttribute;
                    if (attr != null)
                    {
                        list.Add(attr.LocaleType);
                    }
                }
            }
            return list.ToArray();
        }
    }
}
