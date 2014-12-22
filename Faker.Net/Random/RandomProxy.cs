using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Random
{
    public static class RandomProxy
    {
        private static System.Random random = new System.Random();
        public static int CurrentValue { get; private set; }


        public static int Next(int maxValue)
        {
            var r = random.Next(maxValue);
            CurrentValue = r;
            return r;
        }

        public static int Next(int minValue, int maxValue)
        {
            var r = random.Next(minValue, maxValue);
            CurrentValue = r;
            return r;
        }

        public static int Next()
        {
            var r = random.Next(0, 100);
            CurrentValue = r;
            return r;
        }

        public static bool NextBool()
        {
            return random.NextDouble() > 0.5;
        }
    }
}
