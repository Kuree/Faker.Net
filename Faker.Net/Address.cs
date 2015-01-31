using System;
using Faker.Random;

namespace Faker
{
    public class Address : FakerBase
    {
        public Address() : this(LocaleType.en) { }
        public Address(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Address Default { get { return defaultValue; } }
        private static Address defaultValue = new Address();

        private RandomFactory factory;

        public string GetCityPrefix()
        {
            return Selector.GetRandomItemFromList(locale.CityPrefix);
        }

        public string GetCitySuffix()
        {
            return Selector.GetRandomItemFromList(locale.CitySuffix);
        }

        public string GetCityName()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.CityNameFormat));
        }

        public string GetStreetName()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.StreetNameFormat));
        }
        public string GetStreetAddress()
        {
            return this.GetStreetAddress(false);
        }

        public string GetStreetAddress(bool useFullAddress)
        {
            var streetname = factory.Next<string>(Selector.GetRandomItemFromList(locale.StreetAddressFormat));
            return (useFullAddress && locale.HasFullStreetAddress)? streetname + " " + GetSecondStreetAddress() : streetname;
        }

        public string GetSecondStreetAddress()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.SecondaryStreetNameFormat));
        }

        public string GetCounty()
        {
            return "Waiting for data"; // exception will break the example and other applications
        }

        public string GetCountry()
        {
            return Selector.GetRandomItemFromList(locale.Country);
        }

        public string GetCountryCode()
        {
            return Selector.GetRandomItemFromList(locale.CountryCode);
        }

        public string GetState()
        {
            return Selector.GetRandomItemFromList(locale.State);
        }

        public string GetStateAbbr()
        {
            return Selector.GetRandomItemFromList(locale.State);
        }

        public Single GetLatitude()
        {
            return RandomProxy.NextSingle() * 180 - 90;
        }

        public Single GetLongitute()
        {
            return RandomProxy.NextSingle() * 180 - 90;
        }

        public string GetZipCode()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.PostCode));
        }

        public string GetTimeZone()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.TimeZone));
        }
    }
}
