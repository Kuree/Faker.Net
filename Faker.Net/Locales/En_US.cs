namespace Faker.Locales
{
    [Locale(LocaleType.en_US)]
    internal class En_US : En
    {
        public override string[] DomainSuffix
        {
            get
            {
                return new[] { 
                                    "com",
                                    "us",
                                    "biz",
                                    "info",
                                    "name",
                                    "net",
                                    "org"
                
                };
            }
        }
    }
}
