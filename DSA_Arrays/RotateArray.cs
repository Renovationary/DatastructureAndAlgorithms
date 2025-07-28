using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Arrays
{
    public class RotateArray
    {

        public static int[] RotateArrayBruteForce(int[] array, int k)
        {
            int length = array.Length;
            k = k % length;

            // Copy last k elements to temp
            int[] temp = new int[k];
            Array.Copy(array, length - k, temp, 0, k);

            // Shift the rest of the elements to the right
            for (int i = length - k - 1; i >= 0; i--)
            {
                array[i + k] = array[i];
            }

            // Copy temp back to the beginning
            for (int i = 0; i < k; i++)
            {
                array[i] = temp[i];
            }

            return array;
        }

        public static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        // Rotate the array by k steps
        public static int[] RotateOptimal(int[] nums, int k)
        {
            int length = nums.Length;
            k = k % length;

            Reverse(nums, 0, length - 1);     // Reverse entire array
            Reverse(nums, 0, k - 1);          // Reverse first k elements
            Reverse(nums, k, length - 1);     // Reverse remaining elements

            return nums;
        }


    }

}

