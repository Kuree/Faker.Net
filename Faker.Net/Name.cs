using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Net.Locales;

namespace Faker.Net
{
    public class Name : FakerBase
    {
        public Name() : base() { }
        public Name(LocaleType type) : base(type) { }

        // default static interface
        public static Name Default { get { return defaultValue; } }
        private static Name defaultValue = new Name();

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

        public virtual string GetName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName)) firstName = this.GetFirstName();
            if (string.IsNullOrEmpty(lastName)) lastName = this.GetLastName();
            var r = Random.RandomProxy.Next(8);
            switch (r)
            {
                case 0:
                    return string.Format("{0} {1} {2}", this.GetNamePrefix(), firstName, lastName);
                case 1:
                    return string.Format("{0} {1} {2}", firstName, lastName, this.GetNameSuffix());
            }
            return string.Format("{0} {1}", firstName, firstName);
        }
    }
}
