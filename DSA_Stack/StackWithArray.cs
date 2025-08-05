using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Stack
{
    public class StackWithArray
    {
        private int top, cap;
        private int[] a; 

        public StackWithArray(int cap)
        {
            this.cap = cap;
            top = -1; 
            a = new int[cap];
        }

        public bool Push(int x)
        {
            if (top >= cap - 1) {
                Console.WriteLine("Stack overflow");
                return false;
            }
            a[++top] = x;
            return true;
        }

        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0; 
            }
            return a[top--];
        }

        public int Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack is Empty");
                return 0; 
            }
            return a[top];
        }

        public bool IsEmpty()
        {
            return top < 0; 
        }
    }
}
