using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program!");
            LinkedListOperations linkedList = new LinkedListOperations();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add at Last");
                Console.WriteLine("Enter 2 to Add at First");
                Console.WriteLine("Enter 3 to Append data to Linked List");
                Console.WriteLine("Enter 4 to Add data in between of two nodes in Linked List");
                Console.WriteLine("Enter 5 to Delete first data of Linked List");
                Console.WriteLine("Enter 6 to Delete Last data of Linked List");
                Console.WriteLine("Enter 7 to Search data from Linked List");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.InsertAtLast(56);
                        linkedList.InsertAtLast(30);
                        linkedList.InsertAtLast(70);
                        Console.WriteLine("Elements are inserted at last");
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        Console.WriteLine("Elements are inserted at first");
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.InsertAtLast(56);
                        linkedList.InsertAtLast(30);
                        linkedList.InsertAtLast(70);
                        Console.WriteLine("Elements are appended at last");
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.InsertAtLast(56);
                        linkedList.InsertAtLast(70);
                        linkedList.InsertAtMiddle(30);
                        Console.WriteLine("Elements are appended at last");
                        linkedList.Display();
                        break;
                    case 5:
                        Console.WriteLine("After deletion of first node :");
                        linkedList.DeleteFirst();
                        linkedList.Display();
                        break;
                    case 6:
                        Console.WriteLine("After deletion of Last node :");
                        linkedList.DeleteLast();
                        linkedList.Display();
                        break;
                    case 7:
                        Console.WriteLine("Enter the element to found");
                        int target = Convert.ToInt32(Console.ReadLine());
                        var result = linkedList.Search(target);
                        Console.WriteLine(result);
                        break;
                    case 8:
                        return;
                }
            }
           
            

        }
    }
}
