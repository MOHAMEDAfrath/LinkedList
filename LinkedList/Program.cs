using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program!");
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Enter 1 to Add at Last");
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


            }
           
            

        }
    }
}
