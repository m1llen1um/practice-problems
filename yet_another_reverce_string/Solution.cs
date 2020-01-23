using System;

namespace YetAnotherReverceString
{
    public static class Solution
    {

        ///<summary>
        /// Strings are immutable and unles the code is unsafe it's inposible to modify it
        /// new char[] will e required no matter what, possible alternative solutions:
        /// * recursive insertoin to a char[]
        /// * use unsafe - https://docs.microsoft.com/en-us/dotnet/csharp/how-to/modify-string-contents#unsafe-modifications-to-string
        /// </summary>
        public static string Reverce(string inputString)
        {
            // toDo (milen): add validation

            var stringLen = inputString.Length;
            var revercedString = inputString.ToCharArray();
            for (int leftIndex = 0; leftIndex <= stringLen / 2; leftIndex++)
            {
                int rigthIndex = stringLen - 1 - leftIndex;

                if (revercedString[leftIndex] != revercedString[rigthIndex])
                {
                    revercedString[leftIndex] = (char)((int)revercedString[leftIndex] + (int)revercedString[rigthIndex]);
                    revercedString[rigthIndex] = (char)((int)revercedString[leftIndex] - (int)revercedString[rigthIndex]);
                    revercedString[leftIndex] = (char)((int)revercedString[leftIndex] - (int)revercedString[rigthIndex]);
                }
            }
            return new String(revercedString);
        }
    }
}
