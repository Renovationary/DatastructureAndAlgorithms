using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.Patterns.Sliding_Window
{
    public class SmallestSubString
    {
        public static int SmallestSubStringNaive(String S) {
           
            int res = Int32.MaxValue;

            bool zero = false, one = false,two = false;
            int zeroIndex = 0, oneIndex = 0, twoIndex = 0; 
            

            for (int i = 0; i < S.Length; i++) {  
                
                if(S[i] == '0')
                {
                    zero = true;
                    zeroIndex = i; 
                }

                if (S[i] == '1')
                {
                    one = true;
                    oneIndex = i;
                }

                if (S[i] == '2')
                {
                    two = true;
                    twoIndex = i;
                }

                /// index value = Max - Min + 1 ; 

                if (zero & one & two)
                {

                    res = Math.Min(res,
                          Math.Max(zeroIndex, Math.Max(oneIndex, twoIndex))
                          - Math.Min(zeroIndex, Math.Min(oneIndex, twoIndex))); 
                }
            }
            if ( res == Int32.MaxValue )  return -1; 
            return res + 1;
        }

        public static int SmallestSubStringSlidingWindow(string s)
        {
            int n = s.Length, i = 0, k = 0, cnt = 0,
            min_len = int.MaxValue;
            int[] freq = new int[3];
            Array.Fill(freq, 0);

            while (k < n)
            {
                freq[s[k] - '0']++;
                if (freq[s[k] - '0'] == 1)
                    cnt++;
                if (cnt == 3)
                {
                    while (freq[s[i] - '0'] > 1)
                    {
                        freq[s[i] - '0']--;
                        i++;
                    }
                    min_len = Math.Min(min_len, k - i + 1);
                    freq[s[i] - '0']--;
                    i++;
                    cnt--;
                }
                k++;
            }
            return (min_len == int.MaxValue) ? -1 : min_len;
        }
    }
}
