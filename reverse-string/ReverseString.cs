using System;
using Xunit;

namespace reverse_string
{
    public class ReverseString
    {
        public static string Reverse(string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
    }
}
