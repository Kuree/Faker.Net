using System;

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

        public static decimal Next(decimal min, decimal max)
        {
            var d = new decimal(NextInt32(),
                        NextInt32(),
                        Next(0x204FCE5E),
                        false,
                        0);

            return min + (max - min) * d;
        }

        private static int NextInt32()
        {
            byte[] buf = new byte[4];
            random.NextBytes(buf);
            return BitConverter.ToInt32(buf, 0);
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

        public static bool NextBool(double probability)
        {
            return random.NextDouble() < probability;
        }
    }
}
