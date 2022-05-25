using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newnode = new Node(data);
            newnode.next = top;
            top = newnode;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            Console.WriteLine("\nTop element is {0}", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            Node temp = top;
            Console.WriteLine("{0} element is removed",temp.data);
            this.top = this.top.next;
        }
    }
}
