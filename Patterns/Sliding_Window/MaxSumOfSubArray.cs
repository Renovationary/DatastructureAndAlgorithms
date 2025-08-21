using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.Patterns.Sliding_Window
{
    public class MaxSumOfSubArray
    {
        public static int MaxSumOfSubArrayNaive(int sizeOfWindow)
        {
            int max = 0;
            int[] input = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int l = input.Length;
            int k = sizeOfWindow;

            for (int i = 0; i + k <= l; i++) {
                int temp = 0; 

               for (int  j = i; j < i + k;  j++)
                {
                    temp += input[j]; 

                }
               max = Math.Max(max, temp);
            }

            return max; 
        }

        public static int MaxSumOfSubArraySlidingWindow(int sizeOfWindow) { 
        
            int res = 0;
            int[] input = { 1,4,2,10,2,3,1,0,20 };
            int k = sizeOfWindow; 
            int l = input.Length;
 

            for (int i = 0; i < k; i++) { 
                res += input[i];                       
            }

            int current_sum = res;

            for (int i = k; i < l; i++) {
                current_sum += input[i] - input[i - k]; 
                res = Math.Max(current_sum, res);      
            }
            
            return res;
        }
    }
}
