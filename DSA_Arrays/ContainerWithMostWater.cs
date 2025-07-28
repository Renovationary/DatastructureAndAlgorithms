using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Arrays
{
    public class ContainerWithMostWater
    {
        public static int MaxAreaBruteForce(int[] array)
        {
            int area = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int height = Math.Min(array[i], array[j]);
                    int width = j - i;
                    area = Math.Max(area, height * width);
                }
            }
            return area;
        }

        // Optimized two-pointer approach (O(n))
        public static int MaxArea(int[] array)
        {
            int area = 0;
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                int height = Math.Min(array[i], array[j]);
                int width = j - i;
                int newArea = height * width;
                area = Math.Max(area, newArea);

                if (array[i] < array[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return area;
        }
    }
}
