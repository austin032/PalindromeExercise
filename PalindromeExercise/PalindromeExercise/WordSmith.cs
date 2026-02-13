using System.Runtime.InteropServices.JavaScript;
using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        var lower =  word.ToLower();
        char[] array = word.ToCharArray();
        Array.Reverse(array);
        var reversed = new string(array);
        return lower == reversed;
    }
}