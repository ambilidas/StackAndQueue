using System;

namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tStack and Queues");
            Console.WriteLine("Enter 0 for stack operations");
            Console.WriteLine("Enter 1 for Queue operations");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Stack stackobj = new Stack();
                    stackobj.Push(70);
                    stackobj.Push(30);
                    stackobj.Push(56);
                    stackobj.Display();
                    stackobj.Peek();
                    stackobj.Pop();
                    stackobj.Display();
                    break;
                 case 1:
                    Queue queueobj = new Queue();
                    queueobj.Enqueue(56);
                    queueobj.Enqueue(30);
                    queueobj.Enqueue(70);
                    queueobj.Display();
                    queueobj.Dequeue();
                    queueobj.Display();
                    break ;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
           
            Console.ReadKey();

        }
    }
}
