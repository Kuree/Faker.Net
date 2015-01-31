using Faker.Random;

namespace Faker
{
    public class Company : FakerBase
    {
        public Company() : this(LocaleType.en) { }
        public Company(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Company Default { get { return defaultValue; } }
        private static Company defaultValue = new Company();

        private RandomFactory factory;

        public string GetCompanyName()
        {
            return factory.Next<string>(Selector.GetRandomItemFromList(locale.CompanyNameFormat));
        }

        public string GetCompanySuffix()
        {
            return Selector.GetRandomItemFromList(locale.CompanySuffix);
        }

        public string GetCatchPhraseAdjective()
        {
            return Selector.GetRandomItemFromList(locale.CompanyAdjective);
        }

        public string GetCatchPhraseDescriptor()
        {
            return Selector.GetRandomItemFromList(locale.CompanyDescriptor);
        }

        public string GetCatchPhraseNoun()
        {
            return Selector.GetRandomItemFromList(locale.CompanyNoun);
        }

        public string GetCatchPhase()
        {
            return string.Format("{0} {1} {2}", GetCatchPhraseAdjective(), GetCatchPhraseDescriptor(), GetCatchPhraseNoun());
        }
    }
}
