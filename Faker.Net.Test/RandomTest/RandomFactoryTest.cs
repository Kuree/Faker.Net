using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Faker.Net.Random;
using System.Collections.Generic;
using System.Diagnostics;

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

        [TestMethod]
        public void TestRandomSelection()
        {
            RandomProxy random = new RandomProxy();
            int i = random.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(format, d);
            var result = r.GetRandomItemFromProperty<int>("Test1");
            Debug.Write(result);
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
                    list.Add(m << i);
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
