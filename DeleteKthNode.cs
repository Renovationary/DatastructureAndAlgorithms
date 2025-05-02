using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class DeleteKthNode
    {
        public Node DeleteNodeBasedOnInput(Node head, int k)
        {
            //"C:\WesternDigitalDevelopment\LvL_UP\DSA\QuestionsAndPractise\LinkedList\Remove every k-th node of the linked listF(question1_04302025).txt"
            if (head == null || k <= 0) return head;

            Node curr = head;
            Node prev = null;
            int count = 0;

            while (curr != null)
            {
                count++;

                if (count % k == 0)
                {

                    if (prev != null)
                    {
                        prev.next = curr.next;
                    }
                    else
                    {
                        head = curr.next;
                    }
                }
                else
                {
                    prev = curr;

                }
                curr = curr.next; 
            }
            return head; 
        }

        public void PrintList(Node curr)
        {
            while (curr != null)
            {
                Console.WriteLine(curr.data + " ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }
}
