using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.StaticClasses.Exercise.Entities
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs { get; set; } = new List<Dog>();

        public static void PrintAll()
        {
            foreach (var dog in ListOfDogs)
            {
                Console.WriteLine($"Dog name: {dog.Name}, Id: {dog.Id} Color: {dog.Color}");
            }
        }


    }
}
