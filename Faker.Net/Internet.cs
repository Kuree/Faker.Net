using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Net.Locales;
using System.Web.Security;

namespace Faker.Net
{
    public class Internet : FakerBase
    {
        public Internet() : base() { }
        public Internet(LocaleType type) : base(type) { }

        // default static interface
        public static Internet Default { get { return defaultValue; } }
        private static Internet defaultValue = new Internet();

        public virtual string GetPassword() { return this.GetPassword(15); }
        public virtual string GetPassword(int length)
        {
            return Membership.GeneratePassword(length, length << 2);
        }

        public virtual string GetAvatarURL()
        {
            return @"https://s3.amazonaws.com/uifaces/faces/twitter/" + Random.Selector.GetRandomItemFromList<string>(this.locale.AvatarURL);
        }
    }
}
