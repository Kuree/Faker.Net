using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    [LocaleAttribute(Faker.LocaleType.en_GB)]
    internal class En_GB : En
    {
        public override string[] PhoneNumberFormat
        {
            get
            {
                return new string[] {
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
