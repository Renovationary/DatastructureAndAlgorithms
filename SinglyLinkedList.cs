using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class SinglyLinkedList
    {
        public Node head;

        public SinglyLinkedList()
        {
            head = null; 
        }

       
        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode; 

        }

        public void InsertAtTail(int data)
        {
            Node newNode = new Node(data); 
            if(head == null )
            {
                head = newNode;
                return;
            }

            Node current = head;

           while (current.next != null)
            
                current = current.next;
                current.next = newNode; 
            

        }

        public void InsertAtPosition(int data, int position) {

            if (position < 0) throw new ArgumentException("invalid position !"); 


            if(position == 0 )
            {
                InsertAtHead(data);
                return; 
            }

            Node newNode = new Node(data);
            Node current = head;

            for (int i = 0; i < position-1 && current.next != null; i++)  
                
                current = current.next;

            if (current == null) throw new ArgumentException("index out of bound !");

            newNode.next = current.next;
            current.next = newNode; 
            
        }

        public void DeleteHead() {

            if (head == null) return;
            head = head.next; 
        
        }

        public void DeleteTail()
        {
            if (head == null) return; 
            if(head.next == null)
            {
                head = null;
                return; 
            }

            Node current = head;
            while(current.next.next != null)
            {
                current = current.next;
            }
            current.next = null; 
        }

        public void DeleteAtPosition(int Position)
        {
            if (Position < 0) throw new ArgumentException("invalid position!"); 
            if(head == null) return;
            if(Position == 0)
            {
                DeleteHead();
                return; 
            }
            
            Node current = head; 
            for(int i=0; i<Position -1 && current.next != null; i++)
            {
                current = current.next;
            }

            if (current == null) throw new ArgumentException("index out of bound !");
            current.next = current.next.next; 

        }

        public void DeleteByValue(int value)
        {
            if (head == null) return; 

            if(head.data == value)
            {
                head = head.next;
                return; 
            }

            Node current = head; 
            while(current.next != null && current.next.data == value)
                current = current.next;

            if (current.next != null)
                current.next = current.next.next; 

        }

        public bool Search(int value)
        {
            Node current = head; 

            while(current.next !=null)
            {
                if (current.data == value) return true; 
                current = current.next; 
            }
            return false;
        }

        public int IndexOf(int value) {

            Node current = head;
            int index = 0;

            while (current.next != null) {

                if (current.data == value) return index; 
                current= current.next;
                index++;
            }

            return -1; 
        
        }

        public void Tranverse()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data + " -> ");
                current = current.next;
            }

            Console.WriteLine(" "); 
        }

        public void Reverse()
        {
            Node prev = null; 
            Node current = head;
            Node next = null; 


            while(current.next != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next; 
            }

            head = prev; 
        }

        public int GetNthFromEnd(int n)
        {
            Node mainPtr = head, refPtr = head;

            for (int i = 0; i < n; i++)
            {
                if (refPtr == null)
                    throw new ArgumentException("n is greater than the number of nodes");
                refPtr = refPtr.next;
            }

            while (refPtr != null)
            {
                mainPtr = mainPtr.next;
                refPtr = refPtr.next;
            }

            return mainPtr.data;
        }

        public bool DetectLoop()
        {
            Node slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) return true;
            }
            return false;
        }

        public void RemoveDuplicates()
        {
            Node current = head;
            while (current != null && current.next != null)
            {
                if (current.data == current.next.data)
                    current.next = current.next.next;
                else
                    current = current.next;
            }
        }

        public int GetMiddle()
        {
            Node slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
        }

    }
}
