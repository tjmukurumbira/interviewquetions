using InterviewQuestions.Lib;
using System;

namespace InterviewQuestions.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();

        }

        private static void FizzBuzz()
        {
            for (int i = 1; i < 100; i++)
            {
                System.Console.WriteLine($"{i} {FizzBuzzer.GetMessage(i)}");
            }
        }
    }
}
