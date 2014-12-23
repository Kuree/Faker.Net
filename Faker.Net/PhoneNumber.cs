using Faker.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Faker.Random;

namespace Faker
{
    public class PhoneNumber : FakerBase
    {
        public PhoneNumber() : this(LocaleType.en) { }
        public PhoneNumber(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static PhoneNumber Default { get { return defaultValue; } }
        private static PhoneNumber defaultValue = new PhoneNumber();

        private Random.RandomFactory factory;

        public string GetPhoneNumber()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList<string>(locale.PhoneNumberFormat), FormatType.Number);
        }
    }
}
