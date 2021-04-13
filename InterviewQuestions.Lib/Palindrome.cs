using System;
using System.Linq;

namespace InterviewQuestions.Lib
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string testWord)
        {
            if(string.IsNullOrEmpty(testWord))
               return false;
            var lowerTestWord = RemoveSpecialCharacters(testWord).ToLower();
            return CheckPalindromeUsingArrays(lowerTestWord);
        }

        private static bool CheckPalindrome(string lowerTestWord)
        {
            int leftIndex = 0;
            int rightIndex = lowerTestWord.Length - 1;
            while (leftIndex < rightIndex)
            {
                var leftChar = lowerTestWord[leftIndex];
                var rightChar = lowerTestWord[rightIndex];
                if (!leftChar.Equals(rightChar))
                    return false;
                leftIndex++;
                rightIndex--;
            }
            return true;
        }

        private static bool CheckPalindromeUsingArrays(string lowerTestWord)
        {             
            return lowerTestWord.Reverse().SequenceEqual(lowerTestWord);
        }

        private static string RemoveSpecialCharacters(string testWord)
        {
            var test = string.Empty;
            foreach (var c in testWord)
            {
                if (Char.IsLetter(c))
                    test += c;
            }

            return test;
        }
    }
}
