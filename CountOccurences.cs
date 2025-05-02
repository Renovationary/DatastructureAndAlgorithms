using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class CountOccurences
    {
        public int CountOccurenecesRecursive(Node head,int key)
        {
              if (head == null) return 0;

              int occurence = CountOccurenecesRecursive(head.next, key); 
              
              if(head.data == key)
            {
                occurence++; 
            }

            return occurence; 
        }


        public int CountOccurenceTraversing(Node head, int key) {

            int occurence = 0;

            while (head != null) {
                if (head.data == key) {
                    occurence++; 
                }
                head = head.next;
            }

            return occurence; 
        } 
    }
}
