using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program!");
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add at Last");
                Console.WriteLine("Enter 2 to Add at First");
                Console.WriteLine("Enter 3 to Append date to Linked List");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.InsertAtLast(56);
                        //linkedList.InsertAtLast(30);
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
                        return;
                }
            }
           
            

        }
    }
}
