using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Locales;
using System.Collections.Generic;

namespace Faker.Net.Test.LocaleTest
{
    [TestClass]
    public class En
    {
        [TestMethod]
        public void TestCurrencyRead()
        {
            Faker.Locales.En en = new Locales.En();
            var dic = en.Currency;
            dynamic result = dic["UAE Dirham"];
            Assert.AreEqual("AED", result["code"]);
        }
    }
}
