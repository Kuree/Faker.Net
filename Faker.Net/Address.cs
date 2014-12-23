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
            return null;
        }
    }
}
