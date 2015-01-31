using System;

namespace Faker
{
    public enum LocaleType
    {
        de,
        de_AT,
        de_CH,
        en,
        en_AU,
        en_BORK,
        en_CA,
        en_GB,
        en_IND,
        en_US,
        en_au_ocker,
        es,
        fa,
        fr,
        it,
        ja,
        ko,
        nb_NO,
        nep,
        nl,
        pl,
        pt_BR,
        ru,
        sk,
        sv,
        vi,
        zh_CN
    }

}

namespace Faker.Locales
{

    [AttributeUsage(AttributeTargets.Class)]
    internal class LocaleAttribute : Attribute
    {
        public LocaleType LocaleType { get; private set; }
        public LocaleAttribute(LocaleType type)
        {
            this.LocaleType = type;
        }
    }
}
