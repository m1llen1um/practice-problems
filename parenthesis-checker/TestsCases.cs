using System;
using Xunit;

namespace parenthesis_checker
{
    public class TestsCases
    {
        [Fact]
        public void BalancedTest()
        {
            Assert.True(ParenthesisChecker.IsBalanced("[()]"));
        }

        [Fact]
        public void NotBalancedTest()
        {
            Assert.False(ParenthesisChecker.IsBalanced("([()]"));
        }
    }
}
