using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Net.Locales
{
    internal abstract class Locale
    {
        public abstract string Title { get; }
        public abstract LocaleType LocaleType { get; }
        //string[] DefaultCountry { get; }
        public abstract string[] CityPrefix { get; }
        public abstract string[] CitySuffix { get; }
        public abstract string[] Country { get; }
        public abstract string[] CountryCode { get; }
        public abstract string[] TimeZone { get; }

        public abstract string[] CompanySuffix { get; }
        public abstract string[] CompanyAdjective { get; }
        public abstract string[] CompanyDescriptor { get; }
        public abstract string[] CompanyNoun { get; }
        
    }
}
