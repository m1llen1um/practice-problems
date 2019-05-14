namespace RemoveDumps
{
    public class Node
    {
        private Node next = null;

        private int data;

        public Node(int data)
        {
            this.data = data;
        }

        void AppendToTail(int data)
        {
            Node end = new Node(data);
            Node node = this;
            while (node.next != null)
            {
                node = node.next;
            }

            node.next = end;
        }
    }
}