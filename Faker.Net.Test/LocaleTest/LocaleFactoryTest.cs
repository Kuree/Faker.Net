using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Locales;

namespace Faker.Net.Test.LocaleTest
{
    [TestClass]
    public class LocaleFactoryTest
    {
        [TestMethod]
        public void TestCreate()
        {
            Assert.AreEqual(typeof(En), LocaleFactory.Create(LocaleType.en).GetType());
        }
    }
}
