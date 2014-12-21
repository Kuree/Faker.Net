using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Net.Test.RandomTest
{
    public class RandomProxy
    {
        private static System.Random random;
        public int CurrentValue { get; private set; }

        public RandomProxy()
        {
            random = new System.Random();
        }

        public int Next(int maxValue)
        {
            var r = random.Next(maxValue);
            this.CurrentValue = r;
            return r;
        }

        public int Next()
        {
            var r = random.Next(0, 100);
            this.CurrentValue = r;
            return r;
        }
    }
}
