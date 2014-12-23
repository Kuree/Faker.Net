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

        public static long Next(long minValue, long maxValue)
        {
            // code taken from http://stackoverflow.com/questions/6651554/random-number-in-long-range-is-this-the-way
            byte[] buf = new byte[8];
            random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (maxValue - minValue)) + minValue);
        }

        public static long Next(long maxValue)
        {
            return Next(0, maxValue);
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

        public static Single NextSingle()
        {
            return Convert.ToSingle(random.NextDouble());
        }

        public static Double NextDouble(double maxValue)
        {
            return random.NextDouble() * maxValue;
        }
    }
}
