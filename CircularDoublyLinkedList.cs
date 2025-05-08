using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class CircularDoublyLinkedList
    {
        private DoublyNode head; 

       public CircularDoublyLinkedList()
        {
            head = null; 
        }

        public void InsertAtBeginning(int data)
        {
            DoublyNode newnode = new DoublyNode(data);

            if(head == null)
            {
                newnode.next = newnode.prev = newnode; 
                head = newnode;
                return; 
            }

            DoublyNode tail = head.prev;

            newnode.next = head;
            newnode.prev = tail;

            head.prev = newnode;
            tail.next = newnode;

            head = newnode; 
        }

        public void InsertAtEnd(int data) {

            if (head == null) {

                InsertAtBeginning(data);
                return; 

            }

            DoublyNode newNode = new DoublyNode(data);
            DoublyNode tail = head.prev;

            tail.next = newNode;
            newNode.prev = tail;
            newNode.next = head;
            head.prev = newNode; 

        }


        public void InsertAfter(int key, int data)
        {
            if (head == null) return;

            DoublyNode current = head;

            do {

                if(current.Data == key)
                {
                    DoublyNode newNode = new DoublyNode(data);
                    newNode.next = current.next;
                    newNode.prev = current;
                    current.next.prev = newNode;
                    current.next = newNode;
                    return; 
                }

                current = current.next; 
            }
            while (current != head); 
        }


        public void DeleteFromBeginning()
        {
            if (head == null) return; 

            if(head.next == head)
            {
                head = null;
                return; 
            }

            DoublyNode tail = head.prev;
            head = head.next;
            head.prev = tail;
            tail.next = head; 

        }

        public void DeleteFromEnd()
        {
            if (head == null) return;

            if(head.next == head)
            {
                head = null;
                return;
            }

            DoublyNode tail = head.prev;
            tail.prev.next = head;
            head.prev = tail.prev; 
        }

        public void Delete (int key)
        {
            if (head == null) return;

            DoublyNode current = head;
            do { 
            
                if(current.Data == key)
                {
                    if(current == head)
                    {
                        DeleteFromBeginning();
                    }
                    else
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev; 
                    }
                    
                }
                current = current.next;

            }
            while (current.next != head); 
        }

        public void deleteAll()
        {
            head = null; 
        }

        public bool search(int key)
        {
            if (head ==null ) return false;

            DoublyNode current = head;
            do {

                if (current.Data == key)
                    return true; 
                current = current.next;

            }
            while (current.next != head);

            return false;
        }

        public int Count()
        {
            if (head == null) return 0;

            int count = 0;
            DoublyNode current = head;
            do
            {
                count++;
                current = current.next;
            } while (current != head);
            return count;
        }

        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            DoublyNode current = head;
            do
            {
                Console.Write(current.Data + " ");
                current = current.next;
            } while (current != head);
            Console.WriteLine();
        }

        public void DisplayBackward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            DoublyNode current = head.prev;
            DoublyNode tail = current;
            do
            {
                Console.Write(current.Data + " ");
                current = current.prev;
            } while (current != tail);
            Console.WriteLine();
        }

        public void Update(int oldValue, int newValue)
        {
            if (head == null) return;

            DoublyNode current = head;
            do
            {
                if (current.Data == oldValue)
                {
                    current.Data = newValue;
                    return;
                }
                current = current.next;
            } while (current != head);
        }

        public void Reverse()
        {
            if (head == null || head.next == head) return;

            DoublyNode current = head;
            do
            {
                DoublyNode temp = current.next;
                current.next = current.prev;
                current.prev = temp;
                current = temp;
            } while (current != head);

            head = head.next;
        }

        public (CircularDoublyLinkedList, CircularDoublyLinkedList) Split()
        {
            CircularDoublyLinkedList list1 = new CircularDoublyLinkedList();
            CircularDoublyLinkedList list2 = new CircularDoublyLinkedList();

            if (head == null || head.next == head)
            {
                list1.head = this.head;
                return (list1, list2);
            }

            DoublyNode slow = head, fast = head;

            while (fast.next != head && fast.next.next != head)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // List 1
            list1.head = head;
            list1.head.prev = slow;
            DoublyNode tail1 = slow;
            DoublyNode head2 = slow.next;

            tail1.next = head;

            // List 2
            list2.head = head2;
            DoublyNode tail2 = head.prev;

            tail2.next = head2;
            head2.prev = tail2;

            return (list1, list2);
        }

        public void Concatenate(CircularDoublyLinkedList other)
        {
            if (other.head == null) return;
            if (this.head == null)
            {
                this.head = other.head;
                return;
            }

            DoublyNode tail1 = this.head.prev;
            DoublyNode tail2 = other.head.prev;

            tail1.next = other.head;
            other.head.prev = tail1;

            tail2.next = this.head;
            this.head.prev = tail2;
        }

        public void ConverToLinear()
        {
            if (head == null || head.next == head) return; 
            
            DoublyNode tail = head.prev;
            head.prev = null;
            tail.next = null; 

        }

    }
}
