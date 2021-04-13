using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewQuestions.Lib.Tests
{
    public class FizzBuzzGetMessageShould
    {
        [Theory]
        [InlineData(3,"Fizz")]
        [InlineData(33, "Fizz")]
        [InlineData(99, "Fizz")]
        public void ReturnFizzDivisibleByThree(int input, string output) 
        {
            var fizz = FizzBuzzer.GetMessage(input);
            Assert.Equal(output, fizz);
        }


        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(55, "Buzz")]
        public void ReturnBuzzDivisibleByFive(int input, string output)
        {
            var fizz = FizzBuzzer.GetMessage(input);
            Assert.Equal(output, fizz);
        }


        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(90, "FizzBuzz")]
        public void ReturnFizzBuzzDivisibleByThreeAndFive(int input, string output)
        {
            var fizz = FizzBuzzer.GetMessage(input);
            Assert.Equal(output, fizz);

        }

        [Theory]
        [InlineData(7, "")]
        [InlineData(97, "")]
        public void ReturnEmptyStringForNumberNotDivisibleByThreeOrFive(int input, string output)
        {
            var fizz = FizzBuzzer.GetMessage(input);
            Assert.Equal(output, fizz);

        }
    }
}
