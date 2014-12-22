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
        public void TestRandomSelection()
        {
            RandomProxy random = new RandomProxy();
            int i = random.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(format, d);
            var result = r.GetRandomItemFromProperty<int>("Test1", d);
        }

        [TestMethod]
        public void TestRandomFillin()
        {
            RandomProxy random = new RandomProxy();
            int i = random.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(format, d);
            var result = r.FillInRandomData<int>(format, d);
        }

        [TestMethod]
        public void TestNextMethod()
        {
            RandomProxy random = new RandomProxy();
            int i = random.Next();
            DummyClass d = new DummyClass(i);
            string format = @"#{Test1} #{Test2}";
            var r = new Random.RandomFactory(format, d);
            var result = r.Next<int>();
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
