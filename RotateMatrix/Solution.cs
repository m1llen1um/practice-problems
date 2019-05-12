using System;

namespace Rotatematrix
{
    /****************************************************************************************************
    Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
    bytes, write a method to rotate the image by 90 degrees. (an you do this in place?
    ****************************************************************************************************/
    public class Solution
    {
        public static byte[,] RotateInPlace(byte[,] matrixLayer, int length)
        {
            for (int ringIndex = 0; ringIndex < length / 2; ringIndex++)
            {
                for (int swapIndex = ringIndex; swapIndex < length - ringIndex - 1; swapIndex++)
                {
                    byte tmp = matrixLayer[ringIndex, swapIndex];
                    matrixLayer[ringIndex, swapIndex] = matrixLayer[length - swapIndex - 1, ringIndex];
                    matrixLayer[length - ringIndex - 1, swapIndex] = matrixLayer[length - ringIndex - 1, length - swapIndex - 1];
                    matrixLayer[length - ringIndex - 1, length - swapIndex - 1] = matrixLayer[swapIndex, length - ringIndex - 1];
                    matrixLayer[swapIndex, length - ringIndex - 1] = tmp;
                }
            }

            return matrixLayer;
        }

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
    }
}
