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
                // case 1:

            }
           
            Console.ReadKey();

        }
    }
}
