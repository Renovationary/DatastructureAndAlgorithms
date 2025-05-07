using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class DoublyLinkedList
    {
        public DoublyNode Head;
        public DoublyNode Tail;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void InsertAttheBeginnning(int data)
        {

            DoublyNode newNode = new DoublyNode(data);

            // In case list is empty
            if (Head == null)
            {
                Head = Tail = newNode; // new Node is both Head and Tail 
            }
            else
            {
                newNode.next = Head; //link new node to old head
                Head.prev = newNode; //old head linked back to new node
                Head = newNode; //update head

            }
        }

        public void InsertAtTheEnd(int data)
        {
            DoublyNode newNode = new DoublyNode(data);
            //If node is empty 
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.next = newNode; // current tail points to new node
                newNode.prev = Tail; // new node point back to old tail 
                Tail = newNode; // update tail 
            }
        }

        public void InsertAtSpecificPosition(int data,int position) { 
        
            if (position == 0 )
            {
                //need to insert at the beginning since the position is 0
                InsertAttheBeginnning(data);
                return; 
            }

            DoublyNode temp = Head;
            for (int i = 0; i < position - 1 && temp != null; i++) {
                temp = temp.next; // move to the node before position 
            }

            if (temp == null || temp.next == null)
            {
                // position out of bound . 
                InsertAtTheEnd(data); 
                return; 
            }

            DoublyNode newNode = new DoublyNode(data);
            newNode.next = temp.next;
            newNode.prev = temp;
            temp.next.prev = newNode;
            temp.next = newNode; 


            //DoublyNode newNode =new DoublyNode(data);
            //newNode.next = temp.next; // new node points to next node
            //newNode.prev = temp;      // new node point back to temp
            //temp.next.prev = newNode; // next node points back to new Node
            //temp.next = newNode;  //temp points to new node
        
        }

        public void deleteAtBeginning()
        {
            if (Head == null) return;

            if (Head.next == null)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.next;
                Head.prev = null; 
            }

        }

        public void deleteAtLast() {

            if (Tail == null) return; //list is empty
            if (Tail.prev == null) { Head = Tail = null; } //only one node
            else
            {
                Tail = Tail.prev; // move tail to previous node
                Tail.next = null; // new tail has no next node .
            }
        }

        public void deleteAtSpecificPosition(int position)
        {
            if (Head == null) return;

            if (position == 0)
            {
                deleteAtBeginning();
                return;
            }

            DoublyNode temp = Head;

            for (int i = 0; i < position && temp != null ; i++)
                temp = temp.next;

            if (temp == null) return;

            if (temp.next != null)
                temp.next.prev = temp.prev;  //If temp is not the last node, update the next node's Prev pointer to skip over temp.

            if (temp.prev != null) 
                temp.prev.next = temp.next; //If temp is not the first node, update the previous node's Next pointer to skip over temp.

            if (temp == Tail)
                Tail = temp.prev;


        }
        
        public void deleteByVlaue(int data)
        {

            DoublyNode temp = Head; 

            while(temp != null && temp.Data != data)
            {
                temp = temp.next; 

                if (temp == null ) return;

                if (temp == Head)
                    deleteAtBeginning();

                else if (temp == Tail)
                    deleteAtLast(); 
                else
                {
                    temp.prev.next = temp.next;
                    temp.next.prev = temp.prev; 
                }
            }
        }

        public bool Search(int data)
        {
            
            if (data == null) return false;
            DoublyNode temp = Head;

            while (temp != null)
            { 
                temp = temp.next;
                if (temp.Data == data) return true; 
            }

            return false; 
        }

         public int length ()
        {
            DoublyNode temp = Head;
            int count = 0;

            while (temp != null) {
                count++; 
                temp = temp.next;
            }

            return count; 
        }

        public void printForward()
        {
            DoublyNode temp = Head;

            while (temp != null) {

                Console.WriteLine(temp.Data + " ");
                temp = temp.next; 

            }

            Console.WriteLine();
        }

        public void printBackward() {

            DoublyNode temp = Tail;

            while (temp != null) {

                Console.WriteLine(temp.Data + " ");
                temp = temp.prev;

            }

            Console.WriteLine(); 

        }

        public void Clear()
        {
            Head = Tail = null; 
        }

    }
}
