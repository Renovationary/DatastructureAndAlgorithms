using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_DSA_Training.DSA_Queue
{
    public class QueueWithArrayTest
    {
        static Queue<int> q = new Queue<int>();

        public static bool isEmpty()
        {
            return q.Count == 0;
        }

        public static void QEnqueue(int data)
        {
            q.Enqueue(data);
        }

        public static void QDequeue()
        {
            if (isEmpty()) return;
            q.Dequeue();
        }

        public static int GetFront()
        {
            if (isEmpty()) return -1;
            return q.Peek();
        }

        public static int GetRear()
        {
            if (isEmpty()) return -1;
            return q.ToArray()[q.Count - 1];
        }
    }

}
