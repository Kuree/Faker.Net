using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Faker.Locales;

namespace Faker.Locales
{
    public class LocaleFactory
    {
        internal static Locale Create(LocaleType localType)
        {

            foreach(var type in Assembly.GetExecutingAssembly().GetTypes())
            { 
                if (type.BaseType == typeof(Locale) )
                {
                    PropertyInfo info = type.GetProperty("LocaleType", BindingFlags.Static | BindingFlags.Public);
                    if (info != null)
                    {
                        if ((LocaleType)info.GetValue(null, null) == localType)
                        {
                            return Activator.CreateInstance(type) as Locale;
                        }
                    }
                }
            }
            return null;
        }
    }
}
