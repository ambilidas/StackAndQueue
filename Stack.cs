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
            Node newnode=new Node(data);
            newnode.next = top;
            top = newnode;
        }
        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            Node temp = top;
            while(temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
    }
}
