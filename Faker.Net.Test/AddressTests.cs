using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Locales;

namespace Faker.Tests
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        public void GetStreetNameTest()
        {
            Address address = new Address();
            var name = address.GetStreetName();

        }

        [TestMethod()]
        public void GetCityNameTest()
        {

        }

        [TestMethod()]
        public void GetCityPrefixTest()
        {

        }
    }
}
