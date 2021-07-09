using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListOperations
    {
        int count = 0;
        public Node head;
        public void InsertAtLast(int data)
        {
            Node newnode = new Node(data);
            if(head == null)
            {
                count++;
                this.head = newnode;
            }
            else
            {
                count++;
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
                count++;
                this.head = newnode;
            }
            else
            {
                count++;
                newnode.next = head;
                head = newnode;
            }
        }
        public void InsertAtMiddle(int data)
        {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                count++;
                this.head = newnode;
            }
            else
            {
                int middle = 0;
                if (count % 2 == 0)
                {
                    middle = count / 2;

                }
                else
                {
                    middle = (count + 1) / 2;
                }
                    
                    Node temp = this.head;
                    Node current=null;
                    for (int i = 0; i < middle; i++)
                    {
                        current = temp;
                        temp = temp.next;
                    }
                    current.next = newnode;
                    current = newnode;
                    newnode.next = temp;
                


            }


        }
        public Node DeleteFirst()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node DeleteLast()
        {
            if(this.head == null)
            {
                return null;
            }
            if(this.head.next == null)
            {
                return null;
            }
            Node newnode = this.head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return this.head;
        }
        public string Search(int data)
        {
            int flag = 0;

            Node temp = this.head;
            while (temp != null)
            {
                if(temp.data == data)
                {
                    flag = 1;
                }
                
                temp = temp.next;
            }
            return (flag == 1? "Found! "+data: "Not Found");
           
        }
            public void Display()
        {
          
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write("{0}->", temp.data);
                temp = temp.next;
               
            }
            Console.WriteLine(" ");
        }
    }
}
