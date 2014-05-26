using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterview.App.Tasks
{
    public class ReverseALinkedList
    {
        public LinkedList<string> DemoStringLinkedList()
        {
            var list = new LinkedList<string>();

            for (int i = 0; i < 9; i++)
            {
                list.AddLast(new LinkedListNode<string>(string.Format("Node {0}", i)));
            }

            return list;
        }

        public LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
        {
            if (list.Count < 2)
                throw new ArgumentException("You need to provide a list with more than 1 child to swap.");
                
            var first = list.First;
            var second = list.Last;

            for (var i = 0; i < list.Count/2; i++)
            {
                var temp = first.Value;
                first.Value = second.Value;
                second.Value = temp;

                first = first.Next;
                second = second.Previous;
            }

            return list;
        }


        public LinkedList<T> ReverseLinkedList2<T>(LinkedList<T> linkedList)
        {
            return new LinkedList<T>(linkedList.Reverse());
        }
    }
}
