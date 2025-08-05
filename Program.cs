using LinkedList_DSA_Training.DSA_Arrays;

namespace LinkedList_DSA_Training
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Node head = new Node(1);
            //head.next = new Node(2);
            //head.next.next = new Node(3);
            //head.next.next.next = new Node(4);
            //head.next.next.next.next = new Node(5);
            //head.next.next.next.next.next = new Node(6);
            //head.next.next.next.next.next.next = new Node(6);
            //head.next.next.next.next.next.next.next = new Node(6);

            //SinglyLinkedList list = new SinglyLinkedList();
            //list.InsertAtHead(10);
            //list.InsertAtTail(20);
            //list.InsertAtTail(30);
            //list.InsertAtPosition(25, 2);

            //list.Tranverse(); // 10 -> 20 -> 25 -> 30 -> null

            //list.DeleteByValue(25);
            //list.Tranverse(); // 10 -> 20 -> 30 -> null

            //Console.WriteLine("Middle: " + list.GetMiddle()); // 20

            //list.Reverse();
            //list.Tranverse(); // 30 -> 20 -> 10 -> null


            //// *** -------  DoublyLinkedList Start  -------- *** 
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
            //// *** -------   DoublyLinkedList END  -------- *** 


            //// *** -------  Circular Singly LinkedList Start  -------- *** 
            //var list = new CircularSinglyLinkedList();

            //list.InsertAtEnd(10);
            //list.insertAtBeginning(5);
            //list.InsertAtEnd(20);
            //list.InsertAfter(10, 15);

            //Console.WriteLine("List:");
            //list.Display(); // 5 10 15 20

            //list.delete(10);
            //Console.WriteLine("After Deleting 10:");
            //list.Display(); // 5 15 20

            //Console.WriteLine("Count: " + list.Count()); // 3

            //list.Update(15, 17);
            //list.Display(); // 5 17 20

            //Console.WriteLine("Search 20: " + list.Search(20)); // true

            //list.Reverse();
            //Console.WriteLine("Reversed:");
            //list.Display(); // 20 17 5

            //var (l1, l2) = list.Split();
            //Console.WriteLine("Split:");
            //l1.Display();
            //l2.Display();

            //var list2 = new CircularSinglyLinkedList();
            //list2.InsertAtEnd(30);
            //list2.InsertAtEnd(40);

            //l1.Concatenate(list2);
            //Console.WriteLine("After Concatenation:");
            //l1.Display();

            //l1.convertToLinear();
            //Console.WriteLine("Converted to Linear:");
            //l1.Display(); // last node won't link to head
            //// *** -------  Circular Singly LinkedList END  -------- *** 


            //// *** -------  Circular DoublyLinkedList Start  -------- *** 
            //var list = new CircularDoublyLinkedList();

            //list.InsertAtEnd(10);
            //list.InsertAtBeginning(5);
            //list.InsertAtEnd(15);
            //list.InsertAfter(10, 12);

            //Console.WriteLine("Forward:");
            //list.DisplayForward(); // 5 10 12 15

            //Console.WriteLine("Backward:");
            //list.DisplayBackward(); // 15 12 10 5

            //list.Delete(10);
            //list.DisplayForward(); // 5 12 15

            //Console.WriteLine("Count: " + list.Count());

            //list.Update(12, 13);
            //list.DisplayForward(); // 5 13 15

            //list.Reverse();
            //Console.WriteLine("Reversed:");
            //list.DisplayForward(); // 15 13 5

            //var (l1, l2) = list.Split();
            //Console.WriteLine("Split:");
            //l1.DisplayForward();
            //l2.DisplayForward();

            //var list2 = new CircularDoublyLinkedList();
            //list2.InsertAtEnd(99);
            //list2.InsertAtEnd(100);
            //l1.Concatenate(list2);
            //Console.WriteLine("Concatenated:");
            //l1.DisplayForward();

            //l1.ConverToLinear();

            //// *** -------  Circular DoublyLinkedList END -------- *** 


            ///***** ------------- PROBLEMS and SOLVING START ---------- **** 
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


            ///***** ------------- PROBLEMS and SOLVING END  ---------- **** 
            ///



            //Array Starting ..................

            Console.WriteLine("Array Starting ..........");

            //Question 1: 
            int[] ques1InputBruteForceInput = [-4, -1, 0, 3, 10];
            int[] ques1InputBruteForce = SortedArray.sortedArrayBrutedForce(ques1InputBruteForceInput);
            Console.WriteLine("Question 1 Brute force starting...");

            foreach (int i in ques1InputBruteForce)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Question 1 Brute force end ");


            int[] ques1InputTwoPointersInput = [-4, -1, 0, 3, 10];
            int[] ques1InputTwoPointers = SortedArray.sortedUsingTwoPointers(ques1InputTwoPointersInput);
            Console.WriteLine("Question 1 Two Pointers starting...");

            foreach (int i in ques1InputTwoPointers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Question 1 Two Pointer end ");


            Console.WriteLine("Question 2 Monotonic starting...");
            int[] ques2Input = [1, 2, 2, 3];
            bool quest2Results =  Monotonic.IsMonotonic(ques2Input);
            Console.WriteLine("isMonotonic : " +quest2Results);
            Console.WriteLine("Question 2 Monotonic End...");
            Console.WriteLine();




            //Question 3: Rotate Array
            int[] ques3rotateArray = { 1, 2, 3, 4, 5 };
            int[] rotated = RotateArray.RotateArrayBruteForce(ques3rotateArray, 2);

            Console.WriteLine("Question 3 Rotate Array Brute Force starting...");
            Console.Write(string.Join(", ", rotated));
            Console.WriteLine("Question 3 Rotate Array Brute Force ended...");

            int[] ques3rotateArrayOptimal = { 1, 2, 3, 4, 5 };
            int[] rotatedResult = RotateArray.RotateArrayBruteForce(ques3rotateArrayOptimal, 2);

            Console.WriteLine("Question 3 Rotate Array Brute Force starting...");
            Console.Write(string.Join(", ", rotatedResult));
            Console.WriteLine();
            Console.WriteLine("Question 3 Rotate Array Brute Force ended...");

            int[] heights = { 3, 7, 5, 6, 8, 4 };

            int resultBruteForce = ContainerWithMostWater.MaxAreaBruteForce(heights);
            int resultOptimized =  ContainerWithMostWater.MaxArea(heights);

            Console.WriteLine("Brute Force Max Area: " + resultBruteForce);
            Console.WriteLine("Optimized Max Area: " + resultOptimized);

            Console.WriteLine("Array End ..........");
            //Array End ............................
        }

    }

}
