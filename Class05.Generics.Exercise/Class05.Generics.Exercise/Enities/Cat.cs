using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.Generics.Exercise.Enities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Cat:{Name}, {Type}, Age: {Age} Lives left: {LivesLeft}");
        }
    }
}
