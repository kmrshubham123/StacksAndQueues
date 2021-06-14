using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{
    public class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void push(int Value)
        {
            Node node = new Node(Value);
            if(this.top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack" , Value);
        }
        public void Display()
        {
            Node temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
    



}
