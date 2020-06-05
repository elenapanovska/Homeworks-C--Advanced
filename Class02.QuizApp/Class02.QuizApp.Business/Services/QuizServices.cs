using Class02.QuizApp.Data.Data;
using Class02.QuizApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Class02.QuizApp.Business.Services
{
    public class QuizService : InMemoryDatabase
    {
        ValidationService validationService = new ValidationService();

        private User GetUserByUsername(string userName)
        {
            return Users.FirstOrDefault(user => user.UserName.ToLower() == userName.ToLower());
        }
        public void LogIn()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please enter your username and password!");

                Console.Write("Username:");
                string userName = Console.ReadLine();

                if(validationService.DoesUserNameExist(Users, userName) == false)
                {
                    Console.WriteLine("That username does not exist");
                    continue;
                }

                Console.Write("Password:");
                string password = Console.ReadLine();

                User user = GetUserByUsername(userName);

                if(validationService.UsernamePasswordMatch(user, userName, password) == false)
                {
                    Console.WriteLine("Wrong username or password");
                    if(validationService.ThreeAttemptsPass(user, password) == false)
                    {
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                }

                if(user.IsStudent == false)
                {
                    ShowStudents(Users);
                }
                else if(user.IsStudent == true && user.QuizDone == true)
                {
                    Console.WriteLine("You already did the quiz. You cannot do it again!");
                }
                else
                {
                    Quiz(Questions, user);
                }
                
                
                Console.WriteLine("Do you want to log in another user? y/n");
                string choice = Console.ReadLine();
                if(choice == "n")
                {
                    isRunning = !isRunning;
                }
    
            }
           
        }


        public void Quiz(List<QuizQuestion> questions, User user)
        {
            foreach (var question in questions)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine(question.AnswerA);
                Console.WriteLine(question.AnswerB);
                Console.WriteLine(question.AnswerC);
                Console.WriteLine(question.AnswerD);

                Console.Write("Your answer:");
                string studentAnswer = Console.ReadLine();

                if(studentAnswer == question.CorrectAnswer)
                {
                    user.AnsweredCorectly.Add(studentAnswer);
                }
            }

            switch (user.AnsweredCorectly.Count)
            {
                case 1:
                    Console.WriteLine("Your grade is 1! Work harder next time");
                    user.Grade = 1;
                    break;
                case 2:
                    Console.WriteLine("Your grade is 2! Work harder next time");
                    user.Grade = 2;
                    break;
                case 3:
                    Console.WriteLine("Your grade is 3! You can always do better");
                    user.Grade = 3;
                    break;
                case 4:
                    Console.WriteLine("Your grade is 4! Good job!");
                    user.Grade = 4;
                    break;
                case 5:
                    Console.WriteLine("Your grade is 5! Exellent! Bravo! ");
                    user.Grade = 5;
                    break;
                case 0:
                    Console.WriteLine("Your grade is 1, Try to study harder!");
                    user.Grade = 1;
                    break;
            }

            if(user.Grade.ToString() != null)
            {
                user.QuizDone = true;
            }

            Thread.Sleep(3000);
            Console.Clear();

        }

        public void ShowStudents(List<User> students)
        {
            foreach(var student in students)
            {
               if(student.Grade.ToString() != null && student.QuizDone == true && student.IsStudent == true)
               {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.FullName} grade: {student.Grade}, answered questions on the quiz: {student.AnsweredCorectly.Count}");
               }
               else if(student.QuizDone == false && student.IsStudent == true)
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.FullName}");
                    Console.ResetColor();
                }
            }

           
        }
    }
}
