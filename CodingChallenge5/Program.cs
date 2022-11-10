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
            LinkedList<string> myList1 = new LinkedList<string>();

            myList1.AddFirst("Apples");
            myList1.AddFirst("Oranges");
            myList1.AddFirst("Mangos");
            foreach (string str in myList1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            Console.WriteLine("My Least Favorite Fruits:");
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
            //linking with the thirs node
            fourth.prev = third;
            third.next = fourth;

            MyList.WriteList();

        }
    }
}