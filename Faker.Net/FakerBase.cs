using Faker.Net.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Net
{
    public class FakerBase
    {
        private LocaleType localType;
        public LocaleType LocaleType { get { return this.localType; } set { if (this.localType != value) { this.locale = LocaleFactory.Create(value); this.localType = value; } } }
        internal Locales.Locale locale;
        
        public FakerBase() : this(LocaleType.en) { }

        public FakerBase(LocaleType type)
        {
            this.LocaleType = type;
            this.locale = LocaleFactory.Create(type);
        }
    }
}
