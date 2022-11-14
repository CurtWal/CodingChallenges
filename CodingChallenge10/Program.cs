using CodingChallenge10;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
//using System.Collections;
namespace CodeChallenge10
{
   public class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.IsEmpty();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine($"Item popped from Stack : {myStack.Pop()}");
            myStack.PrintStack();

            Console.WriteLine("======Queue======");

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.DeQueue());
            }
            ConcurrentQueue<int> queues = new ConcurrentQueue<int>();
            Thread thread1 = new Thread(() =>
            {
                queues.Enqueue(10);
                queue.Enqueue(20);
            });
            Thread thread2 = new Thread(() =>
            {
                queues.Enqueue(40);
                queues.Enqueue(60);
            });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            while (queues.Count != 0)
            {
                if (queues.TryDequeue(out int x))
                {
                    Console.WriteLine(x); ;
                }
            }
        }
    }
}
