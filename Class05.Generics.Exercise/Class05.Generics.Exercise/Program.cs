using Class05.Generics.Exercise.Enities;
using System;

namespace Class05.Generics.Exercise
{
    class Program
    {
        public static PetStore<Dog> Dogs = new PetStore<Dog>();
        public static PetStore<Cat> Cats = new PetStore<Cat>();
        public static PetStore<Fish> Fish = new PetStore<Fish>();
        static void Main(string[] args)
        {
            Dogs.Pets.Add(new Dog() {Name = "Scooby", Type = "Hysky", Age = 2});
            Dogs.Pets.Add(new Dog() { Name = "Sparky", Type = "Labrador", Age = 1 });

            Cats.Pets.Add(new Cat() { Name = "Missy", Type = "Persian", Age = 3, LivesLeft = 7 });
            Cats.Pets.Add(new Cat() { Name = "Tom", Type = "Persa", Age = 1, LivesLeft = 9 });

            Fish.Pets.Add(new Fish() { Name = "Nemo", Type = "Clown fish", Age = 3, Color = "Orange"  });
            Fish.Pets.Add(new Fish() { Name = "Dory", Type = "Surgeonfish", Age = 4, Color = "Blue"});

            Dogs.BuyPet("scooby");
            Cats.BuyPet("jerry");

            Dogs.PrintPets(Dogs.Pets);
            Cats.PrintPets(Cats.Pets);
            Fish.PrintPets(Fish.Pets);


            Console.ReadLine();
        }
    }
}
