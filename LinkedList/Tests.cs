using System;
using Xunit;

namespace LinkedList
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            int[] initialList = new int[] { 2, 5, 7, 8 };
            int[] reversedList = new int[] { 8, 7, 5, 2 };
            Assert.Equal(reversedList, Solution.ReverseLinkedList(initialList));
        }
    }
}
