/// You are given an array of nonnegative integers. Let's say you start at the
/// beginning of the array and are trying to advance to the end. You can advance at
/// most, the number of steps that you're currently on. Determine whether you can
/// get to the end of the array.
///
/// For example, given the array [1, 3, 1, 2, 0, 1], we can go from indices 0 -> 1
/// -> 3 -> 5, so return true.
///
/// Given the array [1, 2, 1, 0, 0], we can't reach the end, so return false.

using System;
using Xunit;

namespace ArrayAdvancer
{
    public static class Solution
    {
        public static bool IsTraversal(int[] sourceArray)
        {
            if(sourceArray.Length == 0)
            {
                return false;
            }

            return Traverce(0, sourceArray);
        }

        public static bool Traverce(int currentIndex, int[] sourceArray)
        {
            int nextStep = sourceArray[currentIndex];
            if (nextStep == 0)
            {
                return false;
            }

            var nextIndex = currentIndex + nextStep;
            if (nextIndex >= sourceArray.Length - 1)
            {
                return nextIndex == sourceArray.Length - 1;
            }

            bool pathNotFound = false;
            int nextStepIndex = nextStep;
            while (!pathNotFound && nextStepIndex > 0)
            {
                pathNotFound = Traverce(currentIndex + nextStepIndex, sourceArray);
                nextStepIndex--;
            }

            return pathNotFound;
        }
    }
}
