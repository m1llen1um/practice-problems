/*
Given a linked list, sort it in O(n log n) time and constant space.
For example, the linked list 4 -> 1 -> -3 -> 99 should become -3 -> 1 -> 4 -> 99
 */

namespace SortLinkedList
{
    public class Solution
    {

    }

    public class LinkedList
    {
        public LinkedListNode Head { get; set; }

        public void PushNode(int data)
        {
            var newNode = new LinkedListNode(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var currentNode = Head;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = newNode;
        }

        public static void PushNode(LinkedListNode head, LinkedListNode node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            var currentNode = head;
            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = node;
        }

        public void Sort()
        {
            var (a, b) = SplitLinkedList(Head);
        }

        private (LinkedListNode firstLinkedList, LinkedListNode secondLinkedList) SplitLinkedList(LinkedListNode list)
        {
            if (list == null)
            {
                return (null, null);
            }

            if (list.NextNode == null)
            {
                return (list, null);
            }

            var firstHead = list; var fistTail = firstHead;
            var secondHead = list.NextNode; var secondTail = secondHead;
            var currentNode = list.NextNode.NextNode;
            while (!EndOfList(currentNode) && !EndOfList(currentNode.NextNode))
            {
                fistTail.NextNode = currentNode;
                fistTail = fistTail.NextNode;

                secondTail.NextNode = currentNode.NextNode;
                secondTail = secondTail.NextNode;

                currentNode = currentNode.NextNode.NextNode;
            }

            if (currentNode != null)
            {
                fistTail.NextNode = currentNode;
                fistTail = fistTail.NextNode;
            }

            if (currentNode.NextNode != null)
            {
                secondTail.NextNode = currentNode.NextNode;
                secondTail = secondTail.NextNode;
            }

            fistTail.NextNode = null;
            secondTail.NextNode = null;

            return (firstHead, secondHead);
        }

        private bool EndOfList(LinkedListNode node)
        {
            return node.NextNode == null;
        }
    }

    public class LinkedListNode
    {
        public LinkedListNode(int data)
        {
            NextNode = null;
            Data = data;
        }

        public LinkedListNode NextNode { get; set; }

        public int Data { get; set; }
    }
}
