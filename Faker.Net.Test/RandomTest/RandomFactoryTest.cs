using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Random;
using System.Collections.Generic;
using System.Diagnostics;

namespace Faker.Net.Test.RandomTest
{
    [TestClass]
    public class RandomFactoryTest
    {
        [TestMethod]
        public void TestRandomSelection()
        {
            int i = RandomProxy.Next();
            DummyClass d = new DummyClass(i);
            var r = new Random.RandomFactory(d, Locales.LocaleType.en);
            var result = r.GetRandomItemFromProperty<int>("Test1", d);
        }

        [TestMethod]
        public void TestRandomFillin()
        {
            int i = RandomProxy.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(d, Locales.LocaleType.en);
            var result = r.FillInRandomData<int>(format, d);
        }

        [TestMethod]
        public void TestNextMethod()
        {
            int i = RandomProxy.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(d, Locales.LocaleType.en);
            var result = r.Next<int>(format);
        }

        [TestMethod]
        public void TestFakerBaseDictionary()
        {
            Name n = new Name();
            Random.RandomFactory random = new RandomFactory(null, Locales.LocaleType.en);
            Assert.AreEqual(n.GetType(), random.GetFakerObjectFromName("Name").GetType());
        }

        [TestMethod]
        public void TestFakerFillIn()
        {
            string pattern = "@{Name.GetFirstName}";
            Random.RandomFactory random = new RandomFactory(null, Locales.LocaleType.en);
            var result = random.FillInRandomDataFromMethod(pattern);
        }
        public class DummyClass
        {
            public int[] Test1 { get; set; }
            public int[] Test2 { get; set; }
            public DummyClass(int i)
            {
                List<int> list = new List<int>(i);
                for (int m = 0; m < i; m++)
                {
                    list.Add(i << m);
                }
                this.Test1 = list.ToArray();
                list = new List<int>(i);
                for (int m = 0; m < i; m++)
                {
                    list.Add(m << (i + 1));
                }
                this.Test2 = list.ToArray();
            }
        }
    }
}
