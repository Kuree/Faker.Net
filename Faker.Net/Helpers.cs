using Faker.Locales;

namespace Faker
{
    public class Helpers
    {
        public static LocaleType[] GetAvailableLocaleTypes()
        {
            return LocaleFactory.GetAvailableLocales();
        }
    }
}
