using System;

namespace LinkedList
{
    public static class Solution
    {
        public static int[] ReverseLinkedList(int[] data)
        {
            var list = new MyLinkedList(data[0]);
            for (int i = 1; i < data.Length; i++)
            {
                list.AppendNode(data[i]);
            }

            list.ReverseList();
            return list.ToDataArray();
        }
    }
}
