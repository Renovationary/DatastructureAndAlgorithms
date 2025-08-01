using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList_DSA_Training.DSA_HashTable
{
    public class FindTwoSum
    {

        //O(n²) — Two nested loops → quadratic time.
        //Space Complexity: O(1) — Constant space, no extra data structures used.
        public static int[] FindIndicesSum(int[] array, int targetValue)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetValue)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }


        //O(n) — Each element is visited once.
        //Space Complexity: O(n) — In worst case, all elements are stored in the hash table.
        public static int[] FindIndicesSumOptimized(int[] array, int targetValue)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int neededValue = targetValue - array[i];

                if (hashTable.ContainsKey(neededValue))
                {
                    return new int[] { i, hashTable[neededValue] };
                }

                // Store the current value and its index
                if (!hashTable.ContainsKey(array[i]))
                {
                    hashTable[array[i]] = i;
                }
            }

            return Array.Empty<int>();
        }

        public static int[] FindIndicesSumWithHashtable(int[] array, int targetValue)
        {
            Hashtable hashTable = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                int neededValue = targetValue - array[i];

                if (hashTable.ContainsKey(neededValue))
                {
                    return new int[] { i, (int)hashTable[neededValue] };
                }

                if (!hashTable.ContainsKey(array[i]))
                {
                    hashTable[array[i]] = i;
                }
            }

            return Array.Empty<int>();
        }

    }
}
