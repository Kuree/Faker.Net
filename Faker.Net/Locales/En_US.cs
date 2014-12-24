using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    [LocaleAttribute(Faker.LocaleType.en_US)]
    internal class En_US : En
    {
        public override string[] DomainSuffix
        {
            get
            {
                return new string[] { 
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
