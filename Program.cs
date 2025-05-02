namespace LinkedList_DSA_Training
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next = new Node(6);


            // for question 1 
            int k = 1;
            DeleteKthNode qes1 = new DeleteKthNode();
            qes1.DeleteNodeBasedOnInput(head,k);
            qes1.PrintList(head);
        }
    }
}
