using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Net.Random
{
    internal class Selector
    {
        private static System.Random random = new System.Random();

        public static T GetRandomItemFromList<T>(IList<T> list)
        {
            return list[random.Next(list.Count)];
        }
    }
}
