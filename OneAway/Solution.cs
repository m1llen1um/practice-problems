using System;

namespace OneAway
{
/****************************************************************************************************
One Away: There are three types of edits that can be performed on strings: insert a character,
remove a character, or replace a character. Given two strings, write a function to check if they are
one edit (or zero edits) away.
EXAMPLE
-> true
pales. pale -> true
pale, pIe pale. bale -> true
pale. bake -> false
****************************************************************************************************/
    public class Solution
    {
        public static bool IsOneAway(string first, string second)
        {
            var deviation = first.Length - second.Length;
            var isOneAway = false;
            switch (deviation)
            {
                case -1:
                    {
                        isOneAway = CheckMutation(second, first);
                        break;
                    }

                case 0:
                case 1:
                    {
                        isOneAway = CheckMutation(first, second);
                        break;
                    }

                default:
                    {
                        isOneAway = false;
                        break;
                    }
            }

            return isOneAway;
        }

        private static bool CheckMutation(string first, string second)
        {
            var isMutationFound = false;
            for (int firstIndex = 0, secondIndex = 0; firstIndex < first.Length; firstIndex++, secondIndex++)
            {
                bool isPrimaryIndexOutOfRange = firstIndex >= second.Length;
                if (isPrimaryIndexOutOfRange)
                {
                    return true;
                }

                var currentIndexesMatch = first[firstIndex].Equals((second[secondIndex]));
                if (currentIndexesMatch)
                {
                    continue;
                }

                if (isMutationFound)
                {
                    return false;
                }

                isMutationFound = true;
                firstIndex++; // +1
                if (first.Length == second.Length)
                {
                    secondIndex++;
                }

                if (first[firstIndex] != second[secondIndex])
                {
                    return false;
                }
            }

            return isMutationFound;
        }
    }
}
