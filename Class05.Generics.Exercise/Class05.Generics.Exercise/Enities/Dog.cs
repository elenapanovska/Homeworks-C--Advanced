using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.Generics.Exercise.Enities
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog:{Name}, {Type}, Age: {Age}");
        }
    }
}
