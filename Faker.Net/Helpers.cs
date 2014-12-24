using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
    public class Helpers
    {
        public static LocaleType[] GetAvailableLocaleTypes()
        {
            return Faker.Locales.LocaleFactory.GetAvailableLocales();
        }
    }
}
