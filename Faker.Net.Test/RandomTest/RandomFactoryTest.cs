using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Net.Random;

namespace Faker.Net.Test.RandomTest
{
    [TestClass]
    public class RandomFactoryTest
    {
        [TestMethod]
        public void TestFormatRecognization()
        {
            string format = @"#{test1} #{test2}";
            var r = new Random.RandomFactory(format, null);
            var result = r.ReadReadFormat(format);
            Assert.AreEqual("test1", result[0]);
            Assert.AreEqual("test2", result[1]);
        }
    }
}
