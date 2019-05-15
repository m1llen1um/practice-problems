using System.Collections.Generic;

namespace RemoveDumps
{
    /*
    Remove Dups: Write code to remove duplicates from an unsorted linked list. 

    FOLLOW UP: 
    How would you solve this problem if a temporary buffer is not allowed?
    */

    public static class Solution
    {
        public static Node RemoveDumpsWithTempBuffer(Node head)
        {
            var nodeBuffer = new HashSet<int>();
            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (nodeBuffer.Contains(currentNode.Data))
                {
                    previousNode.Next = currentNode.Next;
                    currentNode = currentNode.Next;
                }
                else
                {
                    nodeBuffer.Add(currentNode.Data);
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }

            return head;
        }
    }
}
