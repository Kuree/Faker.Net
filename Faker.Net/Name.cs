using System.Text.RegularExpressions;
using Faker.Random;

namespace Faker
{
    public class Name : FakerBase
    {
        public Name() : this(LocaleType.en) { }
        public Name(LocaleType type) : base(type) { this.factory = new RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Name Default { get { return defaultValue; } }
        private static Name defaultValue = new Name();

        private RandomFactory factory;

        public virtual string GetLastName()
        {
            if (locale.FemaleLastName != null && locale.MaleLastName != null)
            {
                if (RandomProxy.NextBool())
                    return Selector.GetRandomItemFromList(locale.FemaleLastName);
                return Selector.GetRandomItemFromList(locale.MaleLastName);
            }
            return Selector.GetRandomItemFromList(locale.LastName);
        }

        public virtual string GetFirstName()
        {
            if (locale.FemaleFirstName != null && locale.MaleFirstName != null)
            {
                if (RandomProxy.NextBool())
                    return Selector.GetRandomItemFromList(locale.FemaleFirstName);
                return Selector.GetRandomItemFromList(locale.MaleFirstName);
            }
            return Selector.GetRandomItemFromList(locale.FirstName);
        }

        internal virtual string GetNameSuffix()
        {
            return Selector.GetRandomItemFromList(locale.NameSuffix);
        }

        internal virtual string GetNamePrefix()
        {
            return Selector.GetRandomItemFromList(locale.NamePrefix);
        }

        public virtual string GetName() { return this.GetName("", ""); }

        private static string removeNameFormat(string firstName, string lastName, string format)
        {
            string result = format;
            result = result.Replace("{FirstName}", firstName);
            result = result.Replace("{LastName}", lastName);
            var match = Regex.Match(result, "{0.[0-9]+}");
            if (match.Success) result = result.Remove(match.Index, match.Length);
            return result;
        }

        public virtual string GetName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName)) firstName = this.GetFirstName();
            if (string.IsNullOrEmpty(lastName)) lastName = this.GetLastName();
            var defaultFormat = locale.NameFormat[0];
            if(factory.GetProbablyFromFormat(ref defaultFormat))
            {
                return factory.Next<string>(removeNameFormat(firstName, lastName, defaultFormat));
            }
            return factory.Next<string>(removeNameFormat(firstName, lastName, Selector.GetRandomItemFromList
                (locale.NameFormat))); ;
        }
    }
}
