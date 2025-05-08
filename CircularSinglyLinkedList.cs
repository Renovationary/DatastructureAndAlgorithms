using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class CircularSinglyLinkedList
    {
        public Node head;

        public CircularSinglyLinkedList()
        {
            head = null;
        }

        public void insertAtEnd(int data)
        {
            Node newNode = new Node(data);

            if (head == null) {

                head = newNode;
                head.next = head; // point to itself .. circular
                return;
            }

            Node current = head;
            while (current.next != head) {

                current = current.next;
            }

            current.next = newNode;
            newNode.next = head;

        }

        public void insertAtBeginning(int data) {
        
            Node newNode = new Node(data);
            if (head == null) { 
            
                head = newNode;
                newNode.next = head;
                return; 

            }
            Node current = head;
            while (current.next != head)
            {

                current = current.next;
            }

            newNode.next = current;
            current.next = newNode;
            head = newNode; 
        }

        public void InsertAtEnd(int data)
        {
            if(head == null)
            {
                insertAtBeginning(data);
                return; 
            }

            Node newNode = new Node(data);
            Node temp = head;

            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = newNode;
            newNode.next = head; 
         }

        public void InsertAfter(int key, int data)
        {
            if (head == null) return;

            Node current = head;

            do
            {

                if (current.data == key)
                {
                    Node newNode = new Node(data);
                    newNode.next = current.next;
                    current.next = newNode;
                    return;
                }

                current = current.next;
            } while (current != head);
        }

        public void DeleteFromBeginning()
        {
            if (head == null) return; 
            
            if(head.next == head)
            {
                head = null;
                return; 
            }

            Node last = head; 
            while(last.next != head )
                last = last.next;

            head = head.next;
            last.next = head; 

        }

        public void DeleteFromEnd()
        {
            if (head == null) return;

            if(head.next == head)
            {
                head = null;
                return; 
            }

            Node prev = null, current = head; 
            while(current.next != head)
            {
                prev = current; 
                current = current.next;
            }

            prev.next = head; 
        }

        public void delete(int key)
        {

            if (head == null) return;

            Node current = head;
            Node prev = null;

            //special case : deleting head
            if (head.data == key) { 
            
                if (head.next == null )
                {
                    head = null; // Only one node and it's being deleted
                    return; 
                }

                Node tail = head;
                while(tail.next != head)
                {
                    tail = tail.next;  // Find the last node(tail)
                }
                head = head.next;  // Move head to next
                tail.next = head ;// Update last node to point to new head
                return; 
                    
            }

            //General Case
            do
            {
                prev = current;
                current = current.next; 

                if (current.data== key)
                {
                    prev.next = current.next; 
                    return;
                }


            } while (current != head); 

        }

        public void DeleteAll()
        {
            head = null; 
        }

        public bool Search(int key)
        {
            if (head == null) return false;
            Node current = head;

            do
            {

                if (current.data == key) return true;
                current = current.next;

            }
            while (current != head); 
            return false; 
        }

        public void Display()
        {
            Node current = head; 
            if (current == null)
            {
                Console.WriteLine("List is Empty. ");
                return; 
            }

            do {

                Console.WriteLine(current.data + " "); 
                current = current.next;

            }
            while (current != head); 

        }

        public int Count()
        {
            if (head == null) return 0;

            int count = 0; 
            Node current = head;
            do {
                count++; 
                current = current.next;
            } while (current != head);
            return count; 
        }

        public void Clear()
        {
            head = null; 
        }

        public void Update(int oldValue, int newValue)
        {
            if (head == null) return; 

            Node current = head;

            do { 
            
                if(current.data == oldValue)
                {
                    current.data = newValue;
                    return;
                }
                
                current = current.next;

            }
            while (current.next != head);

        }

        
        public void Reverse()
        {
            if(head ==null || head.next == null) return;

            Node prev = null, current = head, next = null;
            Node last = head;
            do {

                next = current.next;
                current.next = prev; 
                prev = current;
                current = next;

            }
            while (current != head);

            head.next = prev;
            head = prev; 
        }

        public void Concatenate(CircularSinglyLinkedList other)
        {

            if(other.head == null) return;

            if (this.head == null) {

                this.head = other.head;
                return;
                
            }

            Node tail1 = head; 
            while(tail1.next != head) 
                tail1 = tail1.next;

            Node tail2 = other.head;
            while (tail2.next != other.head)
                tail2 = tail2.next;

            tail1.next = other.head;
            tail2.next = head; 


        }

        public void convertToLinear()
        {
            if(head == null || head.next == head) return;

            Node current = head;
            while (current.next != head)
                current = current.next;

            current.next = null;
        
        }

        public (CircularSinglyLinkedList, CircularSinglyLinkedList) Split()
        {
            CircularSinglyLinkedList list1 = new CircularSinglyLinkedList();
            CircularSinglyLinkedList list2 = new CircularSinglyLinkedList();

            if (head == null || head.next == head)
            {
                list1.head = this.head;
                return (list1, list2);
            }

            Node slow = head, fast = head;
            while (fast.next != head && fast.next.next != head)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            Node head2 = slow.next;
            Node tail1 = slow;
            Node tail2 = fast.next == head ? fast : fast.next;

            // Complete first half
            tail1.next = head;
            list1.head = head;

            // Complete second half
            tail2.next = head2;
            list2.head = head2;

            return (list1, list2);
        }



    }
}
