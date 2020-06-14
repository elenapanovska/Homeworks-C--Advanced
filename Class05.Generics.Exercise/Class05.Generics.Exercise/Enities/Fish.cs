using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.Generics.Exercise.Enities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish:{Name}, {Type}, Color: {Color}");
        }
    }
}
