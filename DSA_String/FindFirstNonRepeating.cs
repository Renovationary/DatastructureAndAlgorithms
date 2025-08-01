using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_String
{
    public class FindFirstNonRepeating
    {
        public static int findFirstNonRepeating(string s ) {

            int result = -1;

            Dictionary<char,int> hs = new Dictionary<char, int> ();

            foreach (char c in s) { 
                if(hs.ContainsKey(c))
                {
                    hs[c]++;
                }
                else
                {
                    hs[c] = 1; 
                }
            }

            for (int i = 0; i<s.Length; i++)
            {
                if (hs[s[i]] == 1) return i; 
            }

            return result; 
        }
    }
}
