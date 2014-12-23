using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Locales;

namespace Faker
{
    public class Address : FakerBase
    {
        public Address() : this(LocaleType.en) { }
        public Address(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Address Default { get { return defaultValue; } }
        private static Address defaultValue = new Address();

        private Random.RandomFactory factory;

        public string GetZipCode()
        {
            return this.factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(new string[] {"#####", "#####-####" }), Random.FormatType.Number);
        }

        public string GetCityPrefix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CityPrefix);
        }

        public string GetCitySuffix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CitySuffix);
        }

        public string GetCityName()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.CityNameFormat));
        }

        public string GetStreetName()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.StreetNameFormat));
        }
        public string GetStreetAddress()
        {
            return this.GetStreetAddress(false);
        }

        public string GetStreetAddress(bool useFullAddress)
        {
            string numberPattern = string.Concat(Enumerable.Repeat("#", Random.RandomProxy.Next(5)));
            string streetName = GetStreetName();
            return useFullAddress ? factory.Next<string>(numberPattern, Random.FormatType.Number) + " " + streetName + " " + GetSecondStreetAddress() : factory.Next<string>(numberPattern, Random.FormatType.Number) + " " + streetName;
        }

        public string GetSecondStreetAddress()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.SecondaryStreetName));
        }

        public string GetCounty()
        {
            throw new NotImplementedException("Waiting for data");
        }

        public string GetCountry()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.Country);
        }

        public string GetCountryCode()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CountryCode);
        }

        public string GetState()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.State);
        }

        public string GetStateAbbr()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.State);
        }

        public Single GetLatitude()
        {
            return Random.RandomProxy.NextSingle();
        }

        public Single GetLongitute()
        {
            return Random.RandomProxy.NextSingle();
        }

        public string GetZipCode()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.PostCode));
        }
    }
}
