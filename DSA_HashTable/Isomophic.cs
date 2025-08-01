using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_HashTable
{
    public class Isomophic
    {
        public static bool CheckIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, char> sMap = new Dictionary<char, char>();
            Dictionary<char, char> tMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (!sMap.ContainsKey(charS))
                    sMap[charS] = charT;

                if (!tMap.ContainsKey(charT))
                    tMap[charT] = charS;

                if (sMap[charS] != charT || tMap[charT] != charS)
                    return false;
            }

            return true;
        }
    }
}
