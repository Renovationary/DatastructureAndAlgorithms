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
            int n = s.Length;
            int i = 0, k = 0;                 // Window: [i..k]
            int cnt = 0;                      // Distinct digits 0/1/2 present in window
            int min_len = int.MaxValue;
            int[] freq = new int[3];          // freq[0], freq[1], freq[2]

            Console.WriteLine("Start Processing Input: " + s);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Step | i | k | char | Window    | freq[0,1,2] | cnt | min_len");

            int step = 1;

            while (k < n)
            {
                // 1) Expand right: include s[k]
                int dk = s[k] - '0';
                freq[dk]++;
                if (freq[dk] == 1) cnt++;

                Console.WriteLine($"{step++,-4} | {i} | {k} |  {s[k]}    | {s.Substring(i, k - i + 1),-9} | [{freq[0]},{freq[1]},{freq[2]}]   | {cnt}   | {min_len}");

                // 2) If window now has all three digits, shrink from the left
                if (cnt == 3)
                {
                    // Remove redundant leftmost copies
                    while (freq[s[i] - '0'] > 1)
                    {
                        freq[s[i] - '0']--;
                        i++;
                        Console.WriteLine($"{step++,-4} | {i} | {k} | SHRINK | {s.Substring(i, k - i + 1),-9} | [{freq[0]},{freq[1]},{freq[2]}]   | {cnt}   | {min_len}");
                    }

                    // Now [i..k] is the tightest valid window ending at k
                    min_len = Math.Min(min_len, k - i + 1);
                    Console.WriteLine($"{step++,-4} | {i} | {k} | TIGHT  | {s.Substring(i, k - i + 1),-9} | [{freq[0]},{freq[1]},{freq[2]}]   | {cnt}   | {min_len}");

                    // Pop one more from left (make invalid again)
                    freq[s[i] - '0']--;
                    cnt--;
                    i++;
                    Console.WriteLine($"{step++,-4} | {i} | {k} | POP    | {(i <= k ? s.Substring(i, k - i + 1) : ""),-9} | [{freq[0]},{freq[1]},{freq[2]}]   | {cnt}   | {min_len}");
                }

                k++; // move right end forward
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Final Answer (min_len): " + ((min_len == int.MaxValue) ? -1 : min_len));
            return (min_len == int.MaxValue) ? -1 : min_len;
        }

        public static int smallestSubStringSlidingWindowTraining(string s )
        {
            int min_len = int.MaxValue; 
            int n = s.Length;
            int i =0 , k = 0 ;
            int cnt = 0;
            int[] freq = new int[3];

            while (k < n)
            {
                int dk = s[k] - '0';
                freq[dk]++;
                if (freq[dk] ==1 ) cnt++;

                if (cnt == 3) {

                    while (freq[s[i] - '0'] > 1) {
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
            return min_len == int.MaxValue ? -1 : min_len;
        }

    }
}
