using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Random
{
    internal class Selector
    {
        public static T GetRandomItemFromList<T>(IList<T> list)
        {
            if (list == null || list.Count == 0) return default(T);
            return list[RandomProxy.Next(list.Count)];
        }
    }
}
