/*
Given a collection of intervals, find the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.

Intervals can "touch", such as [0, 1] and [1, 2], but they won't be considered overlapping.

For example, given the intervals (7, 9), (2, 4), (5, 8), return 1 as the last interval can be removed and the first two won't overlap.

The intervals are not necessarily sorted in any order.
 */

using System;
using System.Collections.Generic;

namespace OverlapIntervals
{
    public static class Solution
    {
        public static void IntervalsToRemove()
        {
            var sourceIntervals = new Interval[]
            {
                new Interval(2,4),
                new Interval(1,4),
                new Interval(5,6),
                new Interval(3,8),
                new Interval(12,14),
                new Interval(6,8),
            };

            Array.Sort(sourceIntervals, new IntervalsComparer());
            foreach(var interval in sourceIntervals)
            {
                Console.WriteLine($"{interval.StartInterval}:{interval.EndInterval}");
            }
        }
    }

    public class IntervalsComparer : IComparer<Interval>
    {
        public int Compare(Interval left, Interval right)
        {
            if(left.StartInterval < right.StartInterval)
            {
               return -1;
            }

            if(left.StartInterval > right.StartInterval)
            {
               return 1;
            }

            return 0;
        }
    }

    public class Interval
    {
        public int StartInterval {get; set; }
        public int EndInterval {get; set; }

        public Interval(int start, int end)
        {
            StartInterval = start;
            EndInterval = end;
        }
    }
}


/*

 2-4
  3----8
    56
     6-8
          2-4

lastNonOverlapping = sourceIntervals[0];
for each interval (start with second)
   if lastNonOverlapping.End <= current.Start
      lastNonOverlapping = current
      then OK
   else
      add current index to the black list
 */
