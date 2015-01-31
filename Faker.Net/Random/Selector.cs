using System.Collections.Generic;
using System.Linq;

namespace Faker.Random
{
    internal class Selector
    {
        public static T GetRandomItemFromList<T>(IList<T> list)
        {
            if (list == null || list.Count == 0) return default(T);
            return list[RandomProxy.Next(list.Count)];
        }

        public static T GetRandomKeyFromDictionary<T, D>(IDictionary<T, D> dic)
        {
            var keys = dic.Keys.ToArray();
            return GetRandomItemFromList(keys);
        }

        public static T[] GetMultipleRandomItemsFromList<T>(IList<T> list, int count)
        {
            List<T> result = new List<T>(count);
            for(int i = 0; i < list.Count; i++)
            {
                double p = (count - (double)result.Count) / ((double)list.Count - i);
                if (RandomProxy.NextBool(p)) 
                    result.Add(list[i]);
                if (result.Count >= count)
                    return result.ToArray();
            }
            return result.ToArray();
        }
    }
}
