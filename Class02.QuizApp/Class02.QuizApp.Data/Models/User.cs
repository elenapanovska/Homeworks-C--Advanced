using System;
using System.Collections.Generic;
using System.Text;

namespace Class02.QuizApp.Data.Models
{
    public class User 
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool QuizDone { get; set; }
        public bool  IsStudent { get; set; }
        public List<string> AnsweredCorectly { get; set; }
        public int Grade { get; set; }

        public User()
        {
            AnsweredCorectly = new List<string>();
        }

    }
}
