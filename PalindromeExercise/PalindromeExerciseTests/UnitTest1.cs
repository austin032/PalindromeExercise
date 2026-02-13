using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("tuesday", false)]
        [InlineData("saturday", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            WordSmith smith = new WordSmith();
            
            var actual = smith.IsPalindrome(word);
            
            Assert.Equal(expected, actual);
        }
        
        
        
    }
}
