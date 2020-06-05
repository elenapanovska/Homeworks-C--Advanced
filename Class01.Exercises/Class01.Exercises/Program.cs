using System;
using System.Collections.Generic;
using System.Linq;

namespace Class01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameCount();

            //CheckDay();

            RockPaperScrissors();

            Console.ReadLine();
        }

        public static void NameCount()
        {
            bool enterNames = false;
            var input = string.Empty;
            List<string> names = new List<string>();
            while (!enterNames)
            {
                Console.WriteLine("Enter a name! Enter x if you want to stop!");
                input = Console.ReadLine();
                if (input.ToLower() == "x")
                {
                    enterNames = !enterNames;
                }
                else
                {
                    names.Add(input);

                }
            }
            Console.WriteLine("Enter a text!");
            var text = Console.ReadLine();

            List<string> textList = text.Split(" ").ToList();

            foreach (var name in names)
            {
                var occurance = textList.Where(nameInText => nameInText.ToLower().Contains(name.ToLower())).ToList();

                Console.WriteLine($"Name:{name} appears {occurance.Count} times in the text");
            }
        }

        public static void CheckDay()
        {
            bool again = false;
            while (!again)
            {
                Console.WriteLine("Enter a date!");

                DateTime date;
                DateTime.TryParse(Console.ReadLine(), out date);

                DateTime jan1 = new DateTime(date.Year, 1, 1);
                DateTime jan7 = new DateTime(date.Year, 1, 7);
                DateTime apr20 = new DateTime(date.Year, 4, 20);
                DateTime may1 = new DateTime(date.Year, 5, 1);
                DateTime may25 = new DateTime(date.Year, 5, 25);
                DateTime aug3 = new DateTime(date.Year, 8, 3);
                DateTime sep8 = new DateTime(date.Year, 9, 8);
                DateTime oct11 = new DateTime(date.Year, 10, 11);
                DateTime oct23 = new DateTime(date.Year, 10, 23);
                DateTime dec8 = new DateTime(date.Year, 12, 8);

                List<DateTime> hollydays = new List<DateTime>();
                hollydays.Add(jan1);
                hollydays.Add(jan7);
                hollydays.Add(apr20);
                hollydays.Add(may1);
                hollydays.Add(may25);
                hollydays.Add(aug3);
                hollydays.Add(sep8);
                hollydays.Add(oct11);
                hollydays.Add(oct23);
                hollydays.Add(dec8);


                if (hollydays.Contains(date))
                {
                    Console.WriteLine($"{date.Day} {date.Month} {date.DayOfWeek} is not a working day it's a hollyday");
                }
                else if (date.DayOfWeek.ToString().ToLower() == "saturday" || date.DayOfWeek.ToString().ToLower() == "sunday")
                {
                    Console.WriteLine($"{date.DayOfWeek} is a weekend");
                }
                else
                {
                    Console.WriteLine($"{date.DayOfWeek} is a working day");
                }

                Console.WriteLine("Do you want to check anoter date? y/n");
                var yesNo = Console.ReadLine();

                if(yesNo == "n")
                {
                    again = !again;
                }
              
            }
            
        }

        public static void RockPaperScrissors()
        {
            bool play = false;
            int userScore = 0;
            int computerScore = 0;
            int tie = 0;

            while (!play)
            {
                Console.WriteLine("Choose opiton: 1.Play 2.See stats 3.Exit");
                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        bool playing = false;
                        while (!playing)
                        {
                            Console.WriteLine("Choose rock, paper or scissors. Enter 0 to go back!");
                            string userChoice = Console.ReadLine();

                            Random rand = new Random();
                            int randNum = rand.Next(1, 4);
                            string computerChoice;

                            switch (randNum)
                            {
                                case 1:
                                    computerChoice = "rock";
                                    Console.WriteLine("Computer choose rock");
                                    if (userChoice.ToLower() == computerChoice)
                                    {
                                        Console.WriteLine("Its a tie");
                                        tie++;
                                    }
                                    else if (userChoice.ToLower() == "paper" || userChoice.ToLower() == "scissors")
                                    {
                                        Console.WriteLine("Computer wins!");
                                        computerScore++;
                                    }
                                    break;
                                case 2:
                                    computerChoice = "paper";
                                    Console.WriteLine("Computer choose paper");
                                    if (userChoice.ToLower() == computerChoice)
                                    {
                                        Console.WriteLine("Its a tie");
                                        tie++;
                                    }
                                    else if (userChoice.ToLower() == "scissors" || userChoice.ToLower() == "rock")
                                    {
                                        Console.WriteLine("You win!");
                                        userScore++;
                                    }
                                    break;
                                case 3:
                                    computerChoice = "scissors";
                                    Console.WriteLine("Computer choose scissors");
                                    if (userChoice.ToLower() == computerChoice)
                                    {
                                        Console.WriteLine("Its a tie!");
                                        tie++;
                                    }
                                    else if (userChoice.ToLower() == "paper")
                                    {
                                        Console.WriteLine("Computer wins!");
                                        computerScore++;
                                    }
                                    else if (userChoice.ToLower() == "rock")
                                    {
                                        Console.WriteLine("You win!");
                                        userScore++;
                                    }
                                    break;
                            }
                            Console.WriteLine($"User score {userScore} Computer score: {computerScore} Ties: {tie} ");
                            if (userChoice == "0")
                            {
                                playing = !playing;
                            }
                        }
                        break;
                    case "2":
                        int games = userScore + computerScore + tie;
                        var userWinsStats = Convert.ToDecimal(userScore) / games * 100;
                        var userLostStats = Convert.ToDecimal(computerScore) / games * 100;

                        Console.WriteLine($"User score {userScore} Computer score: {computerScore} Ties: {tie} User wins stats: {Math.Round(userWinsStats, 2)}%,  User losing stats: {Math.Round(userLostStats, 2)}%");
                        break;
                    case "3":
                        Environment.Exit(3);
                        break;

                }

            }


        }
    }
}
