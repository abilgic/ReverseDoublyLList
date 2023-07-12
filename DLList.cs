using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDoublyLList
{

    public class DLList
    {
        public Node head;
        public class Node
        {
            public int Data;
            public Node Prev;
            public Node Next;
            public Node() { }
            public Node(int data)
            {
                Data = data;
            }


        }
        public void insert(int data)
        {
            if (head == null)
            {

                head = new Node(data);

                return;
            }

            var current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            var newnode = new Node(data);

            current.Next = newnode;

            newnode.Prev = current;
            newnode.Next = null;

        }
        public void ReverseList()
        {
            if (head == null)
                return;

            Node current = head;
            Node temp = null;


            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }
            head = temp.Prev;
        }

        public void Print()
        {
            if (head == null)
                return;
            var current = head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            };
        }
    }
}


