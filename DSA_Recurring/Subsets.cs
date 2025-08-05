using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Recurring
{
    public class Subsets
    {
        public static IList<IList<int>> SubsetsRer(int[] nums)
        {
            var result = new List<IList<int>>();
            Backtrack(nums, 0, new List<int>(), result);
            return result;
        }

        private static void Backtrack(int[] nums, int start, List<int> current, IList<IList<int>> result)
        {
            // Every path is a valid subset, so add it to result
            result.Add(new List<int>(current));

            // Explore further elements to add to the subset
            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);               // Choose
                Backtrack(nums, i + 1, current, result);  // Explore
                current.RemoveAt(current.Count - 1);       // Backtrack
            }
        }
    }
}
