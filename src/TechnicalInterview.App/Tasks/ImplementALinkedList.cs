using System;

namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * Implement a Linked List in C#

    /*Rules: 
     * Keep a track of the tail node
     * Keep a count of the nodes
     * Get the nth node from the tail - Implement a solution that doesn't use count and only traverses the nodes once
     */

    public class LinkedList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public LinkedList()
        {
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
                Tail = Tail.Next;
            }

            Count++;
        }

        public Node GetNthFromLast(int nthFromLast)
        {
            var pointer1 = Head;
            var pointer2 = Head;

            if (nthFromLast < 1)
                return null;

            //We move pointer2 by the given ammount of nodes
            for (var i = 0; i < nthFromLast - 1; ++i)
            {
                //If the list is less than n nodes we just return a null
                if (pointer2 == null)
                    return null;
           
                pointer2 = pointer2.Next;
            }

            //Progress until end together, pointer 1 will be nthFromLast
            while (pointer2.Next != null)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;
            }

            return pointer1;
        }

        public Node GetByIndex(int index)
        {
            var current = Head;
            for (var i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void WriteNodes()
        {
            var first = Head;

            do
            {
                Console.WriteLine(first.Value);
                first = first.Next;
            } while (first.Next != null);
        }
    }

    public class Node
    {
        public object Value;
        public Node Next;

        public Node(object value)
        {
            Value = value;
        }
    }
}
