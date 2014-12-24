using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    internal class En_CA : En
    {
        public new static LocaleType LocaleType { get { return LocaleType.en_CA; } }

        public override string[] PostCode
        {
            get
            {
                // C# doesn't offer an elegant way to use regex generating the random data.
                // Need to find an nice way to do that without referring to 3rd party library
                return base.PostCode;
            }
        }

        public override string[] State
        {
            get
            {
                return new string[] {
                                "Alberta",
                                "British Columbia",
                                "Manitoba",
                                "New Brunswick",
                                "Newfoundland and Labrador",
                                "Nova Scotia",
                                "Northwest Territories",
                                "Nunavut",
                                "Ontario",
                                "Prince Edward Island",
                                "Quebec",
                                "Saskatchewan",
                                "Yukon"};
            }
        }

        public override string[] StateAbbr
        {
            get
            {
                return new string[] {
                                    "AB",
                                    "BC",
                                    "MB",
                                    "NB",
                                    "NL",
                                    "NS",
                                    "NU",
                                    "NT",
                                    "ON",
                                    "PE",
                                    "QC",
                                    "SK",
                                    "YK"};
            }
        }

        public override string[] DomainSuffix
        {
            get
            {
                return new string[] {
                                "ca",
                                "com",
                                "biz",
                                "info",
                                "name",
                                "net",
                                "org"};
            }
        }

        public override string[] PhoneNumberFormat
        {
            get
            {
                return new string[] {
                                "###-###-####",
                                "(###)###-####",
                                "###.###.####",
                                "1-###-###-####",
                                "###-###-#### x###",
                                "(###)###-#### x###",
                                "1-###-###-#### x###",
                                "###.###.#### x###",
                                "###-###-#### x####",
                                "(###)###-#### x####",
                                "1-###-###-#### x####",
                                "###.###.#### x####",
                                "###-###-#### x#####",
                                "(###)###-#### x#####",
                                "1-###-###-#### x#####",
                                "###.###.#### x#####"};
            }
        }
    }
}
