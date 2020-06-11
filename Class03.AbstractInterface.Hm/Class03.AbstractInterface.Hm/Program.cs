using Class03.AbstractInterface.Hm.Entities;
using System;
using System.Collections.Generic;

namespace Class03.AbstractInterface.Hm
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(1, "Bob", "bobB", "bob123", new List<string>() {"C#Basic", "C#Advanced" });
            Teacher teacher2 = new Teacher(2, "John", "jonhC", "john123", new List<string>() { "JavaScript", "JavaScript Advanced", "Html"}); 

            Student student1 = new Student(3, "Anne", "anneM", "anne12", new List<int>() { 4,5,3,});
            Student student2 = new Student(3, "Lucas", "lucasS", "lucas34", new List<int>() { 2, 4, 3, });

            Console.WriteLine("Teachers");
            teacher1.PrintUser();
            teacher2.PrintUser();
            Console.WriteLine("------------");

            Console.WriteLine("Studnets");
            student1.PrintUser();
            student2.PrintUser();
            Console.WriteLine("------------");



            Console.ReadLine();
        }
    }
}
