using System;
using Xunit;
using Xunit.Abstractions;

namespace Rotatematrix
{
    public class Tests
    {
        private readonly ITestOutputHelper _output;
        public Tests(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void Test3Dim()
        {
            byte[,] photo = new byte[3, 3] {
             { 1, 2, 3 },
             { 4, 5, 6 },
             { 7, 8, 9 },
            };

            DisplayMatrix(3, photo);
            var rotated = Solution.RotateInPlace(photo, 3);
            DisplayMatrix(3, rotated);
        }

        [Fact]
        public void Test4Dim()
        {
            byte[,] photo = new byte[4, 4] {
             { 1, 2, 3, 4    },
             { 5, 6, 7, 8    },
             { 9, 10, 11, 12 },
             {13, 14, 15, 16 },
            };

            DisplayMatrix(4, photo);
            var rotated = Solution.RotateInPlace(photo, 4);
            DisplayMatrix(4, rotated);
        }


        private void DisplayMatrix(int N, byte[,] mat)
        {
            _output.WriteLine("");
            for (int i = 0; i < N; i++)
            {
                string line = String.Empty;
                for (int j = 0; j < N; j++)
                    line += (" " + mat[i, j]);
                _output.WriteLine(line);
            }

            _output.WriteLine("");
        }
    }
}