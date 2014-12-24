using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Locales;
using System.Text.RegularExpressions;

namespace Faker
{
    public class Name : FakerBase
    {
        public Name() : this(LocaleType.en) { }
        public Name(LocaleType type) : base(type) { this.factory = new Random.RandomFactory(this.locale, this.LocaleType); }

        // default static interface
        public static Name Default { get { return defaultValue; } }
        private static Name defaultValue = new Name();

        private Random.RandomFactory factory;

        public virtual string GetLastName()
        {
            if (locale.FemaleLastName != null && locale.MaleLastName != null)
            {
                if (Random.RandomProxy.NextBool())
                    return Random.Selector.GetRandomItemFromList<string>(locale.FemaleLastName);
                else
                    return Random.Selector.GetRandomItemFromList<string>(locale.MaleLastName);
            }
            return Random.Selector.GetRandomItemFromList<string>(locale.LastName);
        }

        public virtual string GetFirstName()
        {
            if (locale.FemaleFirstName != null && locale.MaleFirstName != null)
            {
                if (Random.RandomProxy.NextBool())
                    return Random.Selector.GetRandomItemFromList<string>(locale.FemaleFirstName);
                else
                    return Random.Selector.GetRandomItemFromList<string>(locale.MaleFirstName);
            }
            return Random.Selector.GetRandomItemFromList<string>(locale.FirstName);
        }

        internal virtual string GetNameSuffix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.NameSuffix);
        }

        internal virtual string GetNamePrefix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.NamePrefix);
        }

        public virtual string GetName() { return this.GetName("", ""); }

        private static string removeNameFormat(string firstName, string lastName, string format)
        {
            string result = format;
            result = result.Replace("{FirstName}", firstName);
            result = result.Replace("{LastName}", lastName);
            var match = Regex.Match(result, "{0.[0-9]+}");
            if (match != null) result.Remove(match.Index, match.Length);
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
            else
            {
                return factory.Next<string>(removeNameFormat(firstName, lastName, Random.Selector.GetRandomItemFromList<string>
                    (locale.NameFormat))); ;
            }
        }
    }
}
