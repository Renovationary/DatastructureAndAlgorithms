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
                InsertAtTheEnd(data)
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

    }
}
