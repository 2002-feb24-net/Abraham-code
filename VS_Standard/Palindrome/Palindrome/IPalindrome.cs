using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    interface IPalindrome<String>
    {
        bool paliTest(string s);

        bool emptyNull(string s);
    }
}
