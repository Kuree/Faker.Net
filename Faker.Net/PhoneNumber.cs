using Faker.Random;

namespace Faker
{
    public class PhoneNumber : FakerBase
    {
        public PhoneNumber() : this(LocaleType.en) { }
        public PhoneNumber(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static PhoneNumber Default { get { return defaultValue; } }
        private static PhoneNumber defaultValue = new PhoneNumber();

        private RandomFactory factory;

        public string GetPhoneNumber()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.PhoneNumberFormat), FormatType.Number);
        }
    }
}
