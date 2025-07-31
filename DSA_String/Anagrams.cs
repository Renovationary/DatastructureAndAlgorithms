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
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sorted = new string(chars); // e.g., "eat" → "aet"

                if (!map.ContainsKey(sorted))
                {
                    map[sorted] = new List<string>();
                }

                map[sorted].Add(word);
            }

            var result = new List<IList<string>>();
            foreach (var group in map.Values)
            {
                result.Add(group);
            }

            return result;
        }
    }
}
