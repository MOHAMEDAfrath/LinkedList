using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;
        public void InsertAtLast(int data)
        {
            Node newnode = new Node(data);
            if(head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newnode;
            }

        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            if(this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                newnode.next = head;
                head = newnode;
            }
        }
        public void Display()
        {
          
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write("{0}->", temp.data);
                temp = temp.next;
               
            }
        }
    }
}
