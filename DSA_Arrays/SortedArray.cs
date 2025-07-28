using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Arrays
{
    public class SortedArray
    {

        public static int[] sortedArrayBrutedForce(int[] inputArray)
        {
            int[] results = new int[inputArray.Length];

            for(int i =0; i < inputArray.Length; i++)
            {
                results[i] = (int)Math.Pow(inputArray[i], 2);
            }

            Array.Sort(results);

            return results; 
        }
        //using while loop
        //public static int[] sortedArrayUsingTwoPointers(int[] inputArray)
        //{
        //    int n = inputArray.Length;
        //    int[] results = new int[n];
        //    int left = 0, right = n - 1;
        //    int index = n - 1;
        //    while (left <= right)
        //    {
        //        if (Math.Abs(inputArray[left]) > Math.Abs(inputArray[right]))
        //        {
        //            results[index--] = inputArray[left] * inputArray[left];
        //            left++;
        //        }
        //        else
        //        {
        //            results[index--] = inputArray[right] * inputArray[right];
        //            right--;
        //        }
        //    }
        //    return results;
        //}   

        public static int[] sortedUsingTwoPointers(int[] inputArray)
        {
           int n = inputArray.Length;
           int[] results = new int[n];
           int left = 0 , right = n - 1;

           for(int i = n - 1; i >= 0; i--)
            {
                if (Math.Abs(inputArray[left]) > Math.Abs(inputArray[right]))
                {
                    results[i] = inputArray[left] * inputArray[left];
                    left++;
                }
                else
                {
                    results[i] = inputArray[right] * inputArray[right];
                    right--;
                }
            }
            return results; 
        }

    }
}
