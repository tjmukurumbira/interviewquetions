using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewQuestions.Lib.Tests
{
    public class AnagramIsAnagramShould
    {
        [Theory]
        [InlineData("Anagram", "Nag a ram", true)]
		[InlineData("A gentleman", "Elegant man", true)]
		[InlineData("Oh, lame saint!", "The Mona Lisa", true)]
        [InlineData("Some cars are fast", "Let's race", false)]
        public void ReturnTrueForAnagrams(string firstPhrase, string secondPhrase, bool expectedResult) 
        {  
			var result = Anagram.AreAnagram(firstPhrase, secondPhrase);

            Assert.True(result == expectedResult);
        }
    }
}
