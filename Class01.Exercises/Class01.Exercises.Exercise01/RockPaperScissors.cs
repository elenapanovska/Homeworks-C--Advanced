using System;
using System.Collections.Generic;
using System.Text;

namespace Class01.Exercises.Exercise01
{
    public class RockPaperScissors
    {
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
