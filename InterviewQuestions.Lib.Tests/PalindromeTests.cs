using System;
using Xunit;

namespace InterviewQuestions.Lib.Tests
{
    public class PalindromeIsPalindromeShould
    {
        [Theory]
        [InlineData("madam",true)]
        [InlineData("racecar", true)]
        [InlineData("ana", true)]
        [InlineData("A Santa Lived As a Devil At NASA",true)]
        [InlineData("Do Geese See God?" ,true)]
        public void ReturnTrueIfWordIsPalindrome(string testWord, bool expectedResult)
        {
            
            var result  = Palindrome.IsPalindrome(testWord);

            Assert.Equal(expectedResult,result);

        }

        [Theory]
        [InlineData("madambos", false)]
        [InlineData("A Fast Never Prevents A Fatness", false)]
        public void ReturnFalseIfWordIsNotPalindrome(string testWord, bool expectedResult)
        {
            var result = Palindrome.IsPalindrome(testWord);

            Assert.Equal(expectedResult, result);

        }
    }
}
