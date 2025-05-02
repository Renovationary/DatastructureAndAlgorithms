using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training
{
    public class DoublyNode
    {
        public int Data;
        public DoublyNode prev;
        public DoublyNode next; 

        public DoublyNode(int newData) { 
        
            Data = newData;
            prev = next = null; 
        
        }

    }
}
