using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Recurring
{
    public class Permutation
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Generate(nums, new List<int>(), result);
            return result;
        }

        private static void Generate(int[] nums, List<int> path, IList<IList<int>> result)
        {
            // Base case: if path size == nums size, one full permutation found
            if (path.Count == nums.Length)
            {
                result.Add(new List<int>(path)); // Save a copy of path
                return;
            }

            foreach (int num in nums)
            {
                // Skip number already in path
                if (path.Contains(num)) continue;

                path.Add(num);             // Choose number
                Generate(nums, path, result);  // Explore
                path.RemoveAt(path.Count - 1); // Backtrack (un-choose)
            }
        }

    }
}
