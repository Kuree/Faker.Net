using Faker.Random;

namespace Faker
{
    public class Hacker : FakerBase
    {
        public Hacker() : this(LocaleType.en) { }
        public Hacker(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Hacker Default { get { return defaultValue; } }
        private static Hacker defaultValue = new Hacker();

        private RandomFactory factory;

        public string HackerNoun() { return Selector.GetRandomItemFromList(locale.HackerNoun); }

        public string HackerVerb() { return Selector.GetRandomItemFromList(locale.HackerVerb); }

        public string HackerAdjective() { return Selector.GetRandomItemFromList(locale.HackerAdjective); }

        public string HackerAbbreviation() { return Selector.GetRandomItemFromList(locale.HackerAbbreviation); }

        public string HackerIngVerb() { return Selector.GetRandomItemFromList(locale.HackerIngVerb); }

        public string HackerPhrase() { return factory.Next<string>(Selector.GetRandomItemFromList(locale.HackerPhraseFormat)); }
    }
}
