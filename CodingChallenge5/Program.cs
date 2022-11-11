using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;

namespace CodingChallenge5
{

    //Singly Node
    public class Node
    {
        public Node next;
        public string Items;
    }
    public class LinkedList
    {
        private Node head;
        
        public void AddFirst(string Items)
        {
            Node addNext = new Node();

            addNext.Items = Items;
            addNext.next = head;

            head = addNext;
        }
        public void AddLast(string Items)
        {
            if (head == null)
            {
                head = new Node();

                head.Items = Items;
                head.next = null;
            }
            else
            {
                Node addNext = new Node();
                addNext.Items = Items;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = addNext;
            }
        }
        //challenge 7
        //starting from the last value in a linked list go backwards and display that value /string 
        public void writeNthFromLast(int N)
        {
            Node main = head;
            Node sub = head;

            int count = 0;
            if (head != null)
            {
                while (count < N)
                {
                    if (sub == null)
                    {
                        Console.WriteLine(N + " is greater than the no. " + " of nodes in the list");
                        return;
                    }
                    sub = sub.next;
                    count++;
                }
                if (sub == null)
                {
                    head = head.next;
                    if (head != null)
                        Console.WriteLine("Node no. " + N + " from last is " + main.Items);
                }
                else
                {
                    while (sub != null)
                    {
                        main = main.next;
                        sub = sub.next;
                    }
                    Console.WriteLine("Node no. " + N + " from last is " + main.Items);
                }
            }
        }
    }
    
    //Doubly Node
    public class DoublyNode
    {
        public string Travel;
        public DoublyNode next;
        public DoublyNode prev;
    }
    public class DoublyLinked
    {
        public DoublyNode head;
        public DoublyLinked()
        {
            head = null;
        }
        public void WriteList()
        {
            DoublyNode temp = new DoublyNode();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The DoublyList Contains: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.Travel + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This List is empty.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Favorite Fruits:");
            //making a empty linkedList
            LinkedList<string> myList1 = new LinkedList<string>();
            //adding strings to the list
            myList1.AddFirst("Apples");
            myList1.AddFirst("Oranges");
            myList1.AddFirst("Mangos");

            //foreach loopping through the list to display it one at a time
            foreach (string str in myList1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            Console.WriteLine("My Least Favorite Fruits:");
            //making a new empty linked list to replace the first
            LinkedList<string> myList2 = new LinkedList<string>();

            myList2.AddLast("Watermelons");
            myList2.AddLast("Cherrys");
            myList2.AddLast("Bananas");

            
            foreach (string str in myList2)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("====END OF SINGLY LIST=====");
            Console.WriteLine();

            //Create an empty Linked List
            DoublyLinked MyList = new DoublyLinked();

            //Add first Node
            DoublyNode first = new DoublyNode();
            first.Travel = "Cars";
            first.next = null;
            first.prev = null;

            //linking with head node
            MyList.head = first;

            DoublyNode second = new DoublyNode();
            second.Travel = "Planes";
            second.next = null;
            //linking with the first node
            second.prev = first;
            first.next = second;

            DoublyNode third = new DoublyNode();
            third.Travel = "Boats";
            third.next = null;
            //linking with the second node
            third.prev = second;
            second.next = third;

            DoublyNode fourth = new DoublyNode();
            fourth.Travel = "Bikes";
            fourth.next = null;
            //linking with the third node
            fourth.prev = third;
            third.next = fourth;

            MyList.WriteList();

            //coding challenge 7
            LinkedList myList3 = new LinkedList();
            myList3.AddFirst("Apples");
            myList3.AddFirst("Oranges");
            myList3.AddFirst("Mangos");
            myList3.AddFirst("PineApple");
            //this goes forward not backwards
            myList3.writeNthFromLast(3);

            LinkedList myList4 = new LinkedList();
            myList4.AddLast("Banana");
            myList4.AddLast("Cherry");
            myList4.AddLast("WaterMelon");
            myList4.AddLast("BlueBerries");
            //this goes backwards and throws an expections for a value that is not available 
            myList4.writeNthFromLast(3);
            myList4.writeNthFromLast(6);

        }
    }
}