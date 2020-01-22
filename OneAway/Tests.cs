using Xunit;

namespace OneAway
{
    public class Tests
    {
        [Fact]
        public void Special_TooLongTest()
        {
            Assert.False(Solution.IsOneAway("pale", "papaple"));
        }

        [Fact]
        public void Special_EmptyVariantsTest()
        {
            Assert.False(Solution.IsOneAway("", "pa"));
            Assert.False(Solution.IsOneAway("pa", ""));
            Assert.False(Solution.IsOneAway("", ""));
            Assert.True(Solution.IsOneAway("", "a"));
        }

        [Fact]
        public void GoodDeletionsTest1()
        {
            Assert.True(Solution.IsOneAway("pale", "ple"));
        }

        [Fact]
        public void GoodDeletionTest2()
        {
            Assert.True(Solution.IsOneAway("pale", "ale"));
        }

        [Fact]
        public void GoodDeletionTest3()
        {
            Assert.True(Solution.IsOneAway("pale", "pal"));
        }

        [Fact]
        public void GoodInsertionTest1()
        {
            Assert.True(Solution.IsOneAway("pale", "pales"));
        }

        [Fact]
        public void GoodInsertionTest2()
        {
            Assert.True(Solution.IsOneAway("pale", "ppale"));
        }

        [Fact]
        public void GoodInsertionTest3()
        {
            Assert.True(Solution.IsOneAway("pale", "palle"));
        }
        [Fact]
        public void GoodReplacementTest1()
        {
            Assert.True(Solution.IsOneAway("pale", "pole"));
        }
    }
}
