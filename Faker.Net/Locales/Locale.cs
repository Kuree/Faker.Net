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
        public abstract string[] StreetAddressFormat { get; }
        public abstract bool HasSecondaryStreetAddress { get; }
        public abstract string[] StreetSuffix { get; }
        public abstract string[] SecondaryStreetNameFormat { get; }
        public abstract string[] SecondaryStreetName { get; }
        public abstract string[] Country { get; }
        public abstract string[] CountryCode { get; }
        public abstract string[] State { get; }
        public abstract string[] StateAbbr { get; }
        public abstract string[] TimeZone { get; }
        public abstract string[] PostCode { get; }

        // Company
        public abstract string[] CompanySuffix { get; }
        public abstract string[] CompanyAdjective { get; }
        public abstract string[] CompanyDescriptor { get; }
        public abstract string[] CompanyNoun { get; }
        public abstract string[] CompanyNameFormat { get; }

        // Name
        public abstract string[] FirstName { get; }
        public abstract string[] LastName { get; }
        public abstract string[] FemaleFirstName { get; }
        public abstract string[] MaleFirstName { get; }
        public abstract string[] FemaleLastName { get; }
        public abstract string[] MaleLastName { get; }
        public abstract string[] NamePrefix { get; }
        public abstract string[] NameSuffix { get; }
        public abstract string[] NameFormat { get; }

        // Internet
        public abstract string[] AvatarURL { get; }
        public abstract string[] FreeEmailDomain { get; }
        public abstract string[] DomainSuffix { get; }

        // Finance
        public abstract string[] AccountType { get; }
        public abstract string[] AccountTypeFormat { get; }
        public abstract string[] TransactionType { get; }
        // Use Object because the default JSON paser's bug. 
        // You need to use dynamic to resolve it as well.
        public abstract Dictionary<string, Object> Currency { get; }
        

        // Hacker
        public abstract string[] HackerNoun { get; }
        public abstract string[] HackerVerb { get; }
        public abstract string[] HackerAdjective { get; }
        public abstract string[] HackerAbbreviation { get; }
        public abstract string[] HackerIngVerb { get; }
        public abstract string[] HackerPhraseFormat { get; }

        // Lorem
        public abstract string[] LoremWord { get; }

        // Phone number
        public abstract string[] PhoneNumberFormat { get; }
        
    }
}
