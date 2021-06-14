using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to Stack & Queues-----");
            //UC1:-Create a stack of 56->30->70->
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            //UC2:-pop
            Console.WriteLine("============");
            stack.Pop();
            stack.Peek();
            stack.Display();
        }
    }
}
