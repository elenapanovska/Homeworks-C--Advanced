using Class02.QuizApp.Business.Services;
using System;

namespace Class02.QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var quizService = new QuizService();

            quizService.LogIn();

            Console.ReadLine();
        }
    }
}
