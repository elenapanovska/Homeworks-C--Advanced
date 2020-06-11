using System;
using System.Collections.Generic;
using System.Text;

namespace Class04.StaticClasses.Exercise.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public static void Validate(Dog dog)
        {
            if(dog.Id == 0 || dog.Name == null || dog.Color == null)
            {
                Console.WriteLine("The dog does not have all 3 properties!");
            }
            else if(dog.Id < 0 || dog.Name.Length <= 2)
            {
                Console.WriteLine("The id cannot be less than 0 and the namme needs to be longer than two characters");
            }
            else
            {
                DogShelter.ListOfDogs.Add(dog);
            }
        }
    }
}
