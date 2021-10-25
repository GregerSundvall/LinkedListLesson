using System;
using System.Collections;
using System.Xml.XPath;

namespace  ADT
{
    public class LinkedList<T> : LinkedListInterface<T>
    {
        private ListNode head = null;
        private ListNode tail = null;
        public int Count { get; private set; } = 0;

        public class ListNode
        {
            public T Node;
            public ListNode NextNode;
        }

        public void Pop()
        {
            if (Count < 2)
            {
                Console.WriteLine("List only contains 1 item");
                return;
            }
            var nextToLast = head;
            for (int i = 0; i < Count -1; i++)
            {
                if (i == Count -2)
                {
                    nextToLast.NextNode = null;
                }
                nextToLast = nextToLast.NextNode;
            }
            Count--;
        }
        
        public T GetFromIndex(int index)
        {
            var currentNode = head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }
            return currentNode.Node;
        }
        
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        
        public void Add(T item)
        {
            if (Count == 0)
            {
                head = new ListNode
                {
                    Node = item
                };
                tail = head;
                Count++;
                return;
            }

            tail.NextNode = new ListNode
            {
                Node = item
            };
            tail = tail.NextNode;
            Count++;
        }

        public int IndexOf(T item)
        {
            var currentNode = head;
            for (int i = 0; i < Count; i++)
            {
                if (Equals(currentNode.Node, item))
                {
                    return i;
                }
                currentNode = currentNode.NextNode;
            }
            return -1;
        }
    }
}