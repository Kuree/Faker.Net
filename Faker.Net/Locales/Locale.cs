using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Locales
{
    internal abstract class Locale
    {
        public abstract string Title { get; }
        //string[] DefaultCountry { get; }
        public abstract string[] CityPrefix { get; }
        public abstract string[] CitySuffix { get; }
        public abstract string[] CityNameFormat { get; }
        public abstract string[] StreetNameFormat { get; }
        public abstract string[] SecondaryStreetNameFormat { get; }
        public abstract string[] SecondaryStreetName { get; }
        public abstract string[] Country { get; }
        public abstract string[] CountryCode { get; }
        public abstract string[] State { get; }
        public abstract string[] StateAbbr { get; }
        public abstract string[] TimeZone { get; }
        public abstract string[] PostCode { get; }

        public abstract string[] CompanySuffix { get; }
        public abstract string[] CompanyAdjective { get; }
        public abstract string[] CompanyDescriptor { get; }
        public abstract string[] CompanyNoun { get; }
        public abstract string[] CompanyNameFormat { get; }

        public abstract string[] FirstName { get; }
        public abstract string[] LastName { get; }
        public abstract string[] FemaleFirstName { get; }
        public abstract string[] MaleFirstName { get; }
        public abstract string[] FemaleLastName { get; }
        public abstract string[] MaleLastName { get; }
        public abstract string[] NamePrefix { get; }
        public abstract string[] NameSuffix { get; }

        // Internet
        public abstract string[] AvatarURL { get; }
        public abstract string[] FreeEmailDomain { get; }
        public abstract string[] DomainSuffix { get; }

        
        
    }
}
