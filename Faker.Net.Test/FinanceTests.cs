using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Faker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Faker.Tests
{
    [TestClass()]
    public class FinanceTests
    {
        [TestMethod()]
        public void GetCurrencyCodeTest()
        {
            var key = Finance.Default.GetCurrencyName();
            Locales.En en = new Locales.En();
            Assert.IsTrue(en.Currency.Keys.Contains(key));
        }
    }
}
