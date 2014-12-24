using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    internal class En_US : En
    {
        public new static LocaleType LocaleType { get { return LocaleType.en_US; } }

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
