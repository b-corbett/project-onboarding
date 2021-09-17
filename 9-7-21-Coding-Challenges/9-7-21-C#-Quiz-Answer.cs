using System;
namespace onBoardingQuizzes {
    class Quiz {
        static void Main(string[] args) {
            Console.WriteLine(GiveMeSomething(Console.ReadLine()));
        }

        private static string GiveMeSomething(string a) {
            return "something " + a;
        }
    }
}