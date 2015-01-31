using System.Linq;
using Faker.Locales;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Tests
{
    [TestClass]
    public class FinanceTests
    {
        [TestMethod]
        public void GetCurrencyCodeTest()
        {
            var key = Finance.Default.GetCurrencyName();
            En en = new En();
            Assert.IsTrue(en.Currency.Keys.Contains(key));
        }
    }
}
