using System;
using System.Collections.Generic;
using System.Text;

namespace Class03.AbstractInterface.Hm.Entities
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();


        public Teacher(int id, string name, string username, string password, List<string> subject)
            :base(id, name,  username,  password)   
        {
            Subjects = subject;
        }

        public void PrintSubjects()
        {
            foreach(var subject in Subjects)
            { 
                Console.WriteLine(subject);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher: {Name} Username: {Username} teaches {Subjects.Count} subjects");
        }
    }
}
