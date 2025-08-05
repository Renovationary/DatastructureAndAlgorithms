using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_String
{
    public class Palindrome
    {
        public static bool isPalindrome (string s)
        {
            int left = 0;
            int right = s.Length - 1; 

            while(left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--; 
            }

            return true;
        }
    }
}
