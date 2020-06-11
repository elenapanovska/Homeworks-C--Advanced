using Class04.StaticClasses.Exercise.Entities;
using System;

namespace Class04.StaticClasses.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog() {Id = 1, Name = "Scooby", Color = "Brown"};
            var dog2 = new Dog() {Id = 0,  Color = "Brown"};
            var dog3 = new Dog() {Id = -6, Name = "Sc", Color = "Brown"};
            var dog4 = new Dog() {Id = 4, Name = "Sparky", Color = "White"};

            Dog.Validate(dog1);
            Dog.Validate(dog2);
            Dog.Validate(dog3);
            Dog.Validate(dog4);

            DogShelter.PrintAll();

            Console.ReadLine();
        }
    }
}
