using System;
using Xunit;

namespace reverse_string
{
    public class ReverseStringTests
    {
        [Fact]
        public void ReverseTest()
        {
            const string input = "hello";
            Assert.Equal("olleh", ReverseString.Reverse(input));
        }

        [Fact]
        public void ReverseEmptyTest()
        {
            const string input = "";
            Assert.Equal("", ReverseString.Reverse(input));
        }
    }
}
