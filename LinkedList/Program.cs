using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program!");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            Console.WriteLine("Elements are inserted at last");
            linkedList.Display();

        }
    }
}
