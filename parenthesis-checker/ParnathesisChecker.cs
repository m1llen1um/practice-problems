/// Problem description:
/*** 
Given an expression string exp. Examine whether the pairs and the orders of “{“,”}”,”(“,”)”,”[“,”]” are correct in exp.
For example, the program should print 'balanced' for exp = “[()]{}{[()()]()}” and 'not balanced' for exp = “[(])”

Input:
The first line of input contains an integer T denoting the number of test cases.  Each test case consists of a string of expression, in a separate line.

Output:
Print 'balanced' without quotes if the pair of parenthesis is balanced else print 'not balanced' in a separate line.

Constraints:
1 ≤ T ≤ 100
1 ≤ |s| ≤ 105

Example:
{([])}
()
([]

Output:
balanced
balanced
not balanced


***/

/// Pseudo code:
/***
1. If the string is NULL return 'not balanced'

2. For each character in the string

2.1. If the character is open bracket (one of the '[', '(' or '{') then handle open brackets

2.1.1. Push the character into a stack

2.1.2. Continue with the next character

2.2. If closing bracket (one of the ']', ')' or '}') then handle closing brackets
2.2.1 Check if there are open bracket - if no open brackets, return 'not balanced'
2.2.2 Pop that last character (open bracket) from the stack and check that corresponds to the current character from the list (closing bracket)
2.3. If closing bracket cannot handle (no match between '[' and ']' or '(' and ')' or '{' and '}') return 'not balanced'
3. If the stack is not empty return 'not balanced'
4. Return 'balanced'

***/

/// Implementation description:
/***
For simplicity a dictionary with key - open bracket, value closing bracket is defined:
```
        private static Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };
```

***/
/// Implementation:
/// Performance:
/// Variations:


using System;
using System.Collections.Generic;

namespace parenthesis_checker
{
    public class ParenthesisChecker
    {
        private static Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };

        public static bool IsBalanced(string testCase)
        {
            var openBracketsStack = new Stack<char>();
            foreach (char c in testCase)
            {
                if (brackets.ContainsKey(c))
                {
                    openBracketsStack.Push(c);
                    continue;
                }

                if (brackets.ContainsValue(c))
                {
                    if (openBracketsStack.Count == 0)
                    {
                        return false;
                    }

                    var lastOpenBracket = openBracketsStack.Pop();
                    if (!brackets.TryGetValue(lastOpenBracket, out var lastClosingBracket) || lastClosingBracket != c)
                    {
                        return false;
                    }
                }
            }

            return openBracketsStack.Count == 0;
        }
    }
}
