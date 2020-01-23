using System;
using Xunit;

namespace YetAnotherReverceString
{
    public class Tests
    {
        [Fact]
        public void TestSpoken()
        {
            // Setup
            var spoken = "I've spoken";
            var nekops = "nekops ev'I";

            // Execute
            var actual = Solution.Reverce(spoken);
            Assert.Equal(nekops, actual);
        }

        [Fact]
        public void TestFooo()
        {
            // Setup
            var it = "Fooo";
            var expected = "oooF";

            var actual = Solution.Reverce(it);
            Assert.Equal(expected, actual);
        }

    }
}
