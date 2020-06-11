using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class03.AbstractInterface.Hm.Entities
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();

        public Student(int id, string name, string username, string password, List<int> grades)
           : base(id, name, username, password)
        {
            Grades = grades;
        }


        public void PrintGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Student: {Name} Username: {Username} and average grade of {Grades.Sum() / Grades.Count}");
        }
    }
}
