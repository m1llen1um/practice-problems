using System;
using Xunit;

namespace ArrayAdvancer
{
    public class Tests
    {
        [Fact]
        public void GoodPathTest()
        {
            Assert.True(Solution.IsTraversal(new int[] { 1, 3, 1, 2, 0, 1 }));
        }

        [Fact]
        public void BadPathTest()
        {
            Assert.False(Solution.IsTraversal(new int[] { 1, 2, 1, 0, 0 }));
        }

        [Fact]
        public void NullOrEmptyTest()
        {
            Assert.False(Solution.IsTraversal(new int[] { }));
        }
    }
}