using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge10
{
    internal class Stack
    {
        static readonly int Max = 1000;
        int top;
        int[] stack = new int[Max];

       public bool IsEmpty()
        {
            if (top <= 0)
            {
            return true;
            }
            return false;
        }
        public Stack()
        {
             top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= Max)
            {
                Console.WriteLine("Stack OverFlow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack UnderFlow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack UnderFlow");
                return;
            }
            else
            {
                Console.WriteLine($"The topmost element of The Stack is {stack[top]}");
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class Queue
    {
        LinkedListNode front;
        LinkedListNode rear;

        public Queue()
        {
            front = null;
            rear = null;
        }
        public LinkedListNode GetNode(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            return node;
        } 
        public void Enqueue(int data)
        {
            LinkedListNode newNode = GetNode(data);
            if (front == null)
        {
            front = rear = newNode;
            return;
        }
            rear.next = newNode;
            rear = newNode;
        }
        public int DeQueue()
        {
        int peek = -1;
        if (front != null)
        {
            peek = front.data;
            front = front.next;
        }
        return peek;
        }
        public int GetPeek()
        {
            if (front != null)
            {
                return front.data;
            }
            return -1;
        }
        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
        }
    }

}
