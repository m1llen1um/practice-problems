using System;
using Xunit;

namespace Rotatematrix
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            byte[,] catPhoto = new byte[3, 3] {
             { 1, 2, 3 },
             { 4, 5, 6 },
             { 7, 8, 9 },
            };

            // Solution.Rotate(catPhoto, 3);

            Solution.rotateMatrix(3, catPhoto);
        }
    }
}
