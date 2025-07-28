using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Arrays
{
    public class Monotonic
    {
        public static bool IsMonotonic(int[] inputArray)
        { 
            int left = inputArray[0]; 
            int right = inputArray[inputArray.Length - 1];  
            if (inputArray.Length < 2)
            {
                return true;
            }

            if (left == right)
            {
                for(int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] != left)
                    {
                        return false;
                    }
                }
            }


            if (left < right)
            {
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < inputArray[i - 1])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] > inputArray[i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
