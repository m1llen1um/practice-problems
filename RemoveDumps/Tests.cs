using System;
using Xunit;

namespace RemoveDumps
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            var headNode = new Node(1);
            headNode.AppendToTail(2);
            headNode.AppendToTail(3);
            headNode.AppendToTail(2);
            headNode.AppendToTail(1);
            headNode.AppendToTail(10);

            var result = Solution.RemoveDumpsWithTempBuffer(headNode).ToDataArray();
            Assert.Equal(new int[] { 1, 2, 3, 10 }, result);
        }
    }
}
