using System;

namespace Rotatematrix
{
    /****************************************************************************************************
    Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
    bytes, write a method to rotate the image by 90 degrees. (an you do this in place?
    ****************************************************************************************************/
    public class Solution
    {
        /*
                1.1 1.2             2.1 1.1
                2.1 2.2             2.2 1.2

        j\i -                       -j/i
        |                              |

                1.1 1.2 1.3         3.1 2.1 1.1
                2.1 2.2 2.3         3.2 2.2 1.2
                3.1 3.2 3.3         3.3 2.3 1.3

                i = 0 j = 0     =>   N-j   i
                i = 1 j = 0     =>   N-j   i



             { 1, 2, 3 },
             { 4, 5, 6 },
             { 7, 8, 9 },

             { 7, 4, 1 },
             { 8, 5, 2 },
             { 9, 6, 3 },

0,0 => 0,2 | 1
0,1 => 1,2 | 2
0,2 => 2,2 | 3

1,0 => 0,1 | 4
1,1 => 1,1 | 5
1,2 => 2,1 | 6
...

        */
        public static byte[,] Rotate(byte[,] matrixLayer, int length)
        {
            var rotatedMatrix = new byte[length, length];
            for (int rowIndex = 0; rowIndex < length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < length; colIndex++)
                {
                    rotatedMatrix[colIndex, length - rowIndex - 1] = matrixLayer[rowIndex, colIndex];
                }
            }
            return rotatedMatrix;
        }

        public static void rotateMatrix(int N, byte[,] mat)
        {
            // Consider all  Rotatematrix
            // squares one by one 
            for (int x = 0; x < N / 2; x++)
            {
                // Consider elements  
                // in group of 4 in  
                // current square 
                for (int y = x; y < N - x - 1; y++)
                {
                    // store current cell  
                    // in temp variable 
                    byte temp = mat[x, y];

                    // move values from  
                    // right to top 
                    mat[x, y] = mat[y, N - 1 - x];

                    // move values from 
                    // bottom to right 
                    mat[y, N - 1 - x] = mat[N - 1 - x,
                                            N - 1 - y];

                    // move values from 
                    // left to bottom 
                    mat[N - 1 - x,
                        N - 1 - y] = mat[N - 1 - y, x];

                    // assign temp to left 
                    mat[N - 1 - y, x] = temp;
                }
            }
        }
    }
}
