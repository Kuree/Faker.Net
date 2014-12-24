using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Faker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Faker.Tests
{
    [TestClass()]
    public class HelpersTests
    {
        [TestMethod()]
        public void GetAvailableLocaleTypesTest()
        {
            var result = Faker.Helpers.GetAvailableLocaleTypes();
            Assert.IsTrue(result.Length > 1);
        }
    }
}
