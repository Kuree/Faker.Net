using Faker.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
    public class Hacker : FakerBase
    {
        public Hacker() : this(LocaleType.en) { }
        public Hacker(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Hacker Default { get { return defaultValue; } }
        private static Hacker defaultValue = new Hacker();

        private Random.RandomFactory factory;

        public string HackerNoun() { return Random.Selector.GetRandomItemFromList<string>(locale.HackerNoun); }

        public string HackerVerb() { return Random.Selector.GetRandomItemFromList<string>(locale.HackerVerb); }

        public string HackerAdjective() { return Random.Selector.GetRandomItemFromList<string>(locale.HackerAdjective); }

        public string HackerAbbreviation() { return Random.Selector.GetRandomItemFromList<string>(locale.HackerAbbreviation); }

        public string HackerIngVerb() { return Random.Selector.GetRandomItemFromList<string>(locale.HackerIngVerb); }

        public string HackerPhraseFormat() { return factory.Next<string>(Random.Selector.GetRandomItemFromList<string>(locale.HackerPhraseFormat)); }
    }
}
