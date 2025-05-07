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
            head.next.next.next.next.next.next = new Node(6);
            head.next.next.next.next.next.next.next = new Node(6);


            // for question 1 delete Kth index
            //int k = 1;
            //DeleteKthNode qes1 = new DeleteKthNode();
            //qes1.DeleteNodeBasedOnInput(head,k);
            //qes1.PrintList(head);


            ////for question 2 find the Middle of Node 
            //FindMiddleNode ques2 = new FindMiddleNode();
            //int middleTortiseAAndHare = ques2.FindMiddleNodeTortiseAndHare(head);
            //Console.WriteLine(middleTortiseAAndHare);
            //int middleBruteForce = ques2.FindMiddleNodeBruteForce(head);
            //Console.WriteLine(middleBruteForce); 

            // For Question 3 : Finding the occurences 
            //int key = 6; 
            //CountOccurences ques3 = new CountOccurences();
            //int occurenceRecursive = ques3.CountOccurenecesRecursive(head, key);
            //int occurenceTransverse = ques3.CountOccurenceTraversing(head, key);
            //Console.WriteLine("occurenceRecursive : " + occurenceRecursive); 
            //Console.WriteLine("occurenceTransverse : " + occurenceTransverse); 



            //DoublyLinkedList list = new DoublyLinkedList();

            //list.InsertAtTheEnd(10);
            //list.InsertAttheBeginnning(5);
            //list.InsertAtTheEnd(20);
            //list.InsertAtSpecificPosition(15, 2);

            //Console.WriteLine("Forward:");
            //list.printForward();  // 5 10 15 20

            //Console.WriteLine("Reverse:");
            //list.printBackward();  // 20 15 10 5

            //list.deleteByVlaue(10);
            //list.deleteAtBeginning();
            //list.deleteAtLast();

            //Console.WriteLine("After deletions:");
            //list.printForward();  // 15




            CircularSinglyLinkedList cll = new CircularSinglyLinkedList();

            cll.insertAtEnd(10);
            cll.insertAtEnd(20);
            cll.insertAtEnd(30);
            cll.insertAtBeginning(5);
            cll.Display(); // Output: 5 10 20 30

            Console.WriteLine("Count: " + cll.Count()); // Output: 4

            cll.InsertAfter(20, 25);
            cll.Display(); // Output: 5 10 20 25 30

            cll.delete(10);
            cll.Display(); // Output: 5 20 25 30

            Console.WriteLine("Search 25: " + cll.Search(25)); // Output: True
            Console.WriteLine("Search 100: " + cll.Search(100)); // Output: False

            cll.Clear();
            cll.Display(); // Output: List is empty.
        }   

    }
     
}
