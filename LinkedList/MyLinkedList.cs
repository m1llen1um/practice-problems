using System.Collections.Generic;

namespace LinkedList
{
    public class MyLinkedList
    {
        public MyLinkedList(int data)
        {
            Head = new ListNode
            {
                Data = data,
                NextNode = null,
            };

            Length++;
        }

        public ListNode Head { get; set; }

        public int Length { get; set; } = 0;

        public void AppendNode(int data)
        {
            if (Head == null)
            {
                return;
            }

            var newNode = new ListNode
            {
                Data = data
            };

            var currentNode = Head;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = newNode;
            Length++;
        }


        public void ReverseList()
        {
            var lastNode = RecursiveReverse(Head);
            lastNode.NextNode = null;
        }

        public int[] ToDataArray()
        {
            var dataList = new List<int>();
            var currentNode = Head;
            while (currentNode != null)
            {
                dataList.Add(currentNode.Data);
                currentNode = currentNode.NextNode;
            }

            return dataList.ToArray();
        }

        private ListNode RecursiveReverse(ListNode node)
        {
            if (node.NextNode == null)
            {
                Head = node;
                return node;
            }

            var prevNode = RecursiveReverse(node.NextNode);
            prevNode.NextNode = node;
            return node;
        }
    }
}
