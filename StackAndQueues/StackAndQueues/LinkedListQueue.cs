using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{
    class LinkedListQueue
    {
        Node head;
        public void Enqueue(int data) //Add a new Item to the rear of the Queue
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine(node.data + " inserted into Queue");
        }
        public void Dequeue(int data) //Delete the front item from the Queue
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }
        public void Display() //Display  method to display the Queue
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.WriteLine(n.data + " ");
            }
        }
    }
}
