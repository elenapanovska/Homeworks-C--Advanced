using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class05.Generics.Exercise.Enities
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets = new List<T>();

        public void PrintPets(List<T> pets)
        {
            foreach (T pet in pets)
            {
                Console.WriteLine($"Pet name: {pet.Name}, Pet type: {pet.Type}, {pet.GetType().Name}, Age: {pet.Age} " );
            }
        }

        public void BuyPet(string name)
        {
            var buyPet = Pets.FirstOrDefault(pet => pet.Name.ToLower() == name.ToLower());

            if(buyPet != null)
            {
                Pets.Remove(buyPet);
                Console.WriteLine($"You bought the {buyPet.GetType().Name} {buyPet.Name} ");
            }
            else
            {
                Console.WriteLine("Sorry we do not have that pet at the moment!");
            }
        }
    }
}
