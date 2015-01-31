namespace Faker.Locales
{
    [Locale(LocaleType.en_GB)]
    internal class En_GB : En
    {
        public override string[] PhoneNumberFormat
        {
            get
            {
                return new[] {
                                    "01#### #####",
                                    "01### ######",
                                    "01#1 ### ####",
                                    "011# ### ####",
                                    "02# #### ####",
                                    "03## ### ####",
                                    "055 #### ####",
                                    "056 #### ####",
                                    "0800 ### ####",
                                    "08## ### ####",
                                    "09## ### ####",
                                    "016977 ####",
                                    "01### #####",
                                    "0500 ######",
                                    "0800 ######"};
            }
        }
    }
}
