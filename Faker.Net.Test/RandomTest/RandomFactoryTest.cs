using System;
using System.Collections.Generic;
using Faker.Locales;
using Faker.Random;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var r = new RandomFactory(d, LocaleType.en);
            var result = r.GetRandomItemFromProperty<int>("Test1", d);
            Assert.IsTrue(Array.Exists(d.Test1, n => n == result));
        }

        [TestMethod]
        public void TestRandomFillin()
        {
            int m = RandomProxy.Next();
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test2}";
            var r = new RandomFactory(d, LocaleType.en);            

            for (int i = 0; i < 100000; i++)
            {
                var result = r.FillInRandomData<int>(format, d);
                string[] numbers = result.Split(' ');
                Assert.AreEqual(numbers.Length, 2);
                Assert.IsTrue(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
                Assert.IsTrue(Array.Exists(d.Test2, n => n == int.Parse(numbers[1])));
            }
        }

        [TestMethod]
        public void TestNextMethod1()
        {
            int m = RandomProxy.Next();
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test2}";
            var r = new RandomFactory(d, LocaleType.en);
            for (int i = 0; i < 100000; i++)
            {
                var result = r.Next<int>(format);
                string[] numbers = result.Split(' ');
                Assert.AreEqual(numbers.Length, 2);
                Assert.IsTrue(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
                Assert.IsTrue(Array.Exists(d.Test2, n => n == int.Parse(numbers[1])));
            }
        }

        [TestMethod]
        public void TestNextMethod2()
        {
            int m = RandomProxy.Next(2, 100);
            DummyClass d = new DummyClass(m);
            string format = @"#{Test1} #{Test1}";
            var r = new RandomFactory(d, LocaleType.en);
            var result = r.Next<int>(format);
            string[] numbers = result.Split(' ');
            Assert.AreEqual(numbers.Length, 2);
            Assert.IsTrue(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
            Assert.IsTrue(Array.Exists(d.Test1, n => n == int.Parse(numbers[0])));
            Assert.IsTrue(numbers[0] != numbers[1]);
        }

        [TestMethod]
        public void TestFakerBaseDictionary()
        {
            Name n = new Name();
            RandomFactory random = new RandomFactory(null, LocaleType.en);
            Assert.AreEqual(n.GetType(), random.GetFakerObjectFromName("Name").GetType());
        }

        [TestMethod]
        public void TestFakerFillIn()
        {
            string pattern = "@{Name.GetFirstName}";
            RandomFactory random = new RandomFactory(null, LocaleType.en);
            
            List<string> names = new List<string>();
            En en = new En();
            foreach (var n in en.FirstName) names.Add(n);
            //foreach (var n in en.MaleFirstName) names.Add(n);
            //foreach (var n in en.FemaleFirstName) names.Add(n);
            for (int i  = 0; i < 100000; i++)
            {
                var result = random.FillInRandomDataFromMethod(pattern);
                Assert.IsTrue(names.Contains(result));
            }
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
