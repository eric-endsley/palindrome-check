using System;
using System.Collections.Generic;

namespace Palindrome 
{
  public class PalindromeCheck
    {
      public static bool PalindromeCalc(string input)
      {
        char[] splitInput = input.ToCharArray();
        char[] reverseArray = splitInput; 
        Array.Reverse(reverseArray);
        string palindrome = new string(reverseArray);
        if (input == palindrome)
        {
          return true;
        }
        else 
        {
          return false;
        }
      }
    }
}