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
    }
}
