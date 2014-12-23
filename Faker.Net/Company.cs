using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Locales;

namespace Faker
{
    public class Company : FakerBase
    {
        public Company() : this(LocaleType.en) { }
        public Company(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Company Default { get { return defaultValue; } }
        private static Company defaultValue = new Company();

        private Random.RandomFactory factory;

        public string GetCompanyName()
        {
            return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.CompanyNameFormat));
        }

        public string GetCompanySuffix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CompanySuffix);
        }

        public string GetCatchPhraseAdjective()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CompanyAdjective);
        }

        public string GetCatchPhraseDescriptor()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CompanyDescriptor);
        }

        public string GetCatchPhraseNoun()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.CompanyNoun);
        }

        public string GetCatchPhase()
        {
            return string.Format("{0} {1} {2}", GetCatchPhraseAdjective(), GetCatchPhraseDescriptor(), GetCatchPhraseNoun());
        }
    }
}
