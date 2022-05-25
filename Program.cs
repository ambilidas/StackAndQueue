using System;

namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tStack and Queues");
            Stack stackobj = new Stack();
            stackobj.Push(70);
            stackobj.Push(30);
            stackobj.Push(56);
            stackobj.Display();
            Console.ReadKey();

        }
    }
}
