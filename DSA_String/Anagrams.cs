using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_String
{
    public class Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                // Sort the characters to create a key
                var key = new string(str.OrderBy(c => c).ToArray());

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(str);
            }

            return map.Values.ToList<IList<string>>();
        }

    }
}
