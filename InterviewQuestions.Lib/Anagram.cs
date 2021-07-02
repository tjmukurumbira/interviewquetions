using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Lib
{
    public class Anagram
    {
        public static bool AreAnagram(string firstPhrase, string secondPhrase) 
        {
            string phraseOne = RemoveSpecialCharacters(firstPhrase);
            string phraseTwo = RemoveSpecialCharacters(secondPhrase);
            if (phraseOne.Length != phraseTwo.Length)
                return false;
            var x1 = phraseOne.ToLower().OrderBy(c => c).ToArray();
            var x2 = phraseTwo.ToLower().OrderBy(c => c).ToArray();
            return (x1.SequenceEqual(x2));
          
        }

        private static string RemoveSpecialCharacters(string phrase)
        {
            string result = string.Empty;
            foreach (var ch in phrase) 
            {
                if (Char.IsLetter(ch))
                    result += ch;
            }
            return result;
        }
    }
}
