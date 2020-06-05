using Class02.QuizApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class02.QuizApp.Data.Data
{
    public class InMemoryDatabase
    {
        protected List<User> Users { get; set; }
        protected List<QuizQuestion> Questions { get; set; }



        public InMemoryDatabase()
        {
            InitializeDatabase();
            InitializeQuestions();
        }

        public void InitializeDatabase()
        {
            Users = new List<User>
            {
                new User(){FullName = "Bob Bobsky" , UserName = "teacherBob", Password = "bobsky123"},
                new User(){FullName = "Anne Marie" , UserName = "anneM", Password = "mariee12" , IsStudent = true },
                new User(){FullName = "John Clark" , UserName = "johnC", Password = "clarkJ", IsStudent = true },
                new User(){FullName = "Lucas Smith" , UserName = "lucasSmith", Password = "smith123", IsStudent = true }
            };
        }

        public void InitializeQuestions()
        {
            Questions = new List<QuizQuestion>
            {
                new QuizQuestion("What is the capital of Tasmania?", "1: Dodoma", "2:Hobart", "3: Launceston", "4: Wellington", "2" ),
                new QuizQuestion("What is the tallest building in the Republic of the Congo?", "1: Kinshasa Democratic Republic of the Congo Temple", 
                                 "2:Palais de la Nation", "3: Kongo Trade Centre", "4: Nabemba Tower", "4" ),
                new QuizQuestion("Which of these is not one of Pluto's moons?", "1: Styx", "2:Hydra", "3: Nix", "4: Lugia", "4" ),
                new QuizQuestion("What is the smallest lake in the world?", "1: Onega Lake", "2:Benxi Lake", "3: Kivu Lake", "4: Wakatipu Lake", "2" ),
                new QuizQuestion("What country has the largest population of alpacas?", "1:Chad", "2: Peru", "3:Australia", "4:Niger", "2" ),

            };
        }
    }
}
