using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    public class DictionaryOperations
    {
        public Dictionary<string, int> InitializeDictionary(int count)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                dictionary.Add("key" + i, random.Next(1, 100));
            }
            return dictionary;
        }

        public IEnumerable<KeyValuePair<string, int>> ProcessDictionary(Dictionary<string, int> dictionary)
        {
            var sortedDictionary = dictionary.OrderBy(x => x.Value);
            int count = (int)Math.Ceiling(sortedDictionary.Count() / 2.0);
            var firstHalf = sortedDictionary.Take(count);
            var sortedFirstHalf = firstHalf.OrderByDescending(x => x.Key);
            var result = sortedFirstHalf.Select(x => new KeyValuePair<string, int>(x.Key, x.Value * (x.Value + 1)));
            return result;
        }
    }
}
