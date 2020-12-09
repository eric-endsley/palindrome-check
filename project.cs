using System;
using System.Collections.Generic;
using Palindrome;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word to find out if it is a palindrome");
    string userInput = Console.ReadLine();
    bool result = PalindromeCheck.PalindromeCalc(userInput);
    Console.WriteLine(result);
  }
}