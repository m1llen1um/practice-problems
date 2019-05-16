using System;
using Xunit;

namespace SortLinkedList
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var s = new LinkedList();
            s.PushNode(1);
            s.PushNode(2);
            s.PushNode(3);
            s.PushNode(4);
            s.PushNode(5);
            s.PushNode(6);
            s.PushNode(1);
            s.Sort();
        }
    }
}
