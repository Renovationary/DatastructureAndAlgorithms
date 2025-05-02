using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class FindMiddleNode
    {
        public int FindMiddleNodeTortiseAndHare(Node head)
        {

            Node fast_pointer = head;
            Node slow_pointer = head;


            while (fast_pointer != null && fast_pointer.next != null)
            {

                fast_pointer = fast_pointer.next.next;
                slow_pointer = slow_pointer.next;

            }

            return slow_pointer.data;

        }


        public int FindMiddleNodeBruteForce(Node head)
        {
            Node node = head;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }

            int middle = count / 2;

            node = head; // <-- Reset here
            while (middle-- > 0)
            {
                node = node.next;
            }

            return node.data;
        }



    }
}
