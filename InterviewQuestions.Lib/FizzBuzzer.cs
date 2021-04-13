using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Lib
{
    public class FizzBuzzer
    {
        public static string GetMessage(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0)
                result = "Fizz";
            if (input % 5 == 0)
                result += "Buzz";
            return result;
        }
    }
}
