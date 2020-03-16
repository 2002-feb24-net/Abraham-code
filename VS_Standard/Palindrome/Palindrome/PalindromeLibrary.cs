using Palindrome.Library;
using System;

namespace Palindrome
{
    public class PalindromeLibrary : IPalindrome<String>
    {
        public bool paliTest(string s)
        {
            char[] arr = s.ToCharArray();
            int end = arr.Length - 1;

            for (int i = 0; i < end; i++)
            {
                if (arr[i] != arr[end - i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool emptyNull(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            return true;
        }
    }
}
