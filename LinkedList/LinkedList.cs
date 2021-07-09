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
        /// <summary>
        /// Insert at last
        /// </summary>
     
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
        //Finds the last element
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Add the element to first
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
        //Inserts at middle
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
                count++;
                    current.next = newnode;
                    current = newnode;
                    newnode.next = temp;
                


            }


        }
        //Deletes first
        public Node DeleteFirst()
        {
            if(this.head == null)
            {
                count--;
                return null;
            }
            count--;
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// Deletes last
        /// </summary>
        /// <returns></returns>
        public Node DeleteLast()
        {
            if(this.head == null)
            {
                count--;
                return null;
            }
            if(this.head.next == null)
            {
                count--;
                return null;
            }
            Node newnode = this.head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            count--;
            return this.head;
        }
        //Search node
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
        //Inserts at specified location
        public Node InsertAtSpecificPosition(int key,int data)
        {
            Node newnode = new Node(data);
            Node temp = this.head;
            Node current = null;
            while (temp != null)
            {
                if(temp.data == key)
                {
                    current = temp;
                      temp = temp.next;
                    break;
                   
                }
                temp = temp.next;
              
                
            }
            count++;
            current.next = newnode;
            newnode.next = temp;
            return this.head;
            
        }
        //Deletes the given node
        public Node DeleteGivenNode(int data)
        {
            Node temp = this.head;
            Node current = null;
            if (temp.data == data)
            {
                count--;
                this.head = temp.next;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        count--;
                        current.next = temp.next;
                        break;
                    }
                    current = temp;
                    temp = temp.next;
                }
            }
            return this.head;
            Size();

        }
        //Sorts the element
        public void Sort()
        {
            Node temp = this.head;
            for(;temp!=null;temp= temp.next)
            {
                for(Node cur = temp.next; cur != null; cur = cur.next)
                {
                    if (temp.data > cur.data)
                    {
                        int temporary = temp.data;
                        temp.data = cur.data;
                        cur.data = temporary;
                    }
                }

            }

        }
        //returns the size
        public int Size()
        {
            return count;
        }
        //Size is returned
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
