using System.Collections.Generic;

namespace RemoveDumps
{
    public class Node
    {
        public Node Next { get; set; } = null;

        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        public void AppendToTail(int data)
        {
            Node end = new Node(data);
            Node node = this;
            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = end;
        }

        public int[] ToDataArray()
        {
            var dataList = new List<int>();
            var currentNode = this;
            while (currentNode != null)
            {
                dataList.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return dataList.ToArray();
        }
    }
}
