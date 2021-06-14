using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{
    public class LinkedListStack
    {
        public Node top; //starting of Stack defining position top
        public LinkedListStack()
        {
            this.top = null;
        }
        public void push(int Value)// Method of adding (add the element in stack)
        {
            Node node = new Node(Value);//creating the object of the node class and pushing into it
            if (this.top==null)
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
        public void Peek() // Method to Display the top element of the stack
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is the top of the Stack" , this.top.data);
        }
        public void Pop() // Method to Remove the top most element from the stack
        {
            if(this.top ==null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value is popped {0} " , this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()    /// check stack is empty or not.
        {
            while (this.top!=null)
            {
                Peek();
                Pop();
            }

        }

    }
    



}
