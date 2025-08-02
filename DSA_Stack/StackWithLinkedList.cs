using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Stack
{
    public class StackWithLinkedList
    {
        private Node head;
        public StackWithLinkedList()
        {
            this.head = null;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            if (new_node == null)
            {
                Console.WriteLine("\n Stack Overflow");
                return;
            }

            new_node.next = head;
            head = new_node;
        }

        public void pop()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("\n Stack Underflow");
            }
            head = head.next;
        }

        public int peek()
        {
            if (!isEmpty())
            {
                return head.data;
            }
            else
            {
                Console.WriteLine("\nStack is Empty");
                return int.MinValue;
            }
        }

    }
}
