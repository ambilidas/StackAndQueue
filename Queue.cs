using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.next = newnode;
                rear = rear.next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
    }
}
