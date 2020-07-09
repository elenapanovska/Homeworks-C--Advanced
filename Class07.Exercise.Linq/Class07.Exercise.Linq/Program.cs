using Class07.Exercise.Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class07.Exercise.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Dog> dogs = new List<Dog>()
			{
				new Dog("Charlie", "Black", 3, Race.Collie), // 0
				new Dog("Buddy", "Brown", 1, Race.Doberman),
				new Dog("Max", "Olive", 1, Race.Plott),
				new Dog("Archie", "Black", 2, Race.Mutt),
				new Dog("Oscar", "White", 1, Race.Mudi),
				new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
				new Dog("Ollie", "Silver", 4, Race.Dalmatian),
				new Dog("Bailey", "White", 4, Race.Pointer),
				new Dog("Frankie", "Gray", 2, Race.Pug),
				new Dog("Jack", "Black", 5, Race.Dalmatian),
				new Dog("Chanel", "Black", 1, Race.Pug), // 10
				new Dog("Henry", "White", 7, Race.Plott),
				new Dog("Bo", "Maroon", 1, Race.Boxer),
				new Dog("Scout", "Olive", 2, Race.Boxer),
				new Dog("Ellie", "Brown", 6, Race.Doberman),
				new Dog("Hank", "Silver", 2, Race.Collie), // 15
				new Dog("Shadow", "Silver", 3, Race.Mudi),
				new Dog("Diesel", "Brown", 4, Race.Bulldog),
				new Dog("Abby", "Black", 1, Race.Dalmatian),
				new Dog("Trixie", "White", 8, Race.Pointer), // 19
			};

			List<Person> people = new List<Person>()
			{
				new Person("Nathanael", "Holt", 20, Job.Choreographer),
				new Person("Rick", "Chapman", 35, Job.Dentist),
				new Person("Oswaldo", "Wilson", 19, Job.Developer),
				new Person("Kody", "Walton", 43, Job.Sculptor),
				new Person("Andreas", "Weeks", 17, Job.Developer),
				new Person("Kayla", "Douglas", 28, Job.Developer),
				new Person("Richie", "Campbell", 19, Job.Waiter),
				new Person("Soren", "Velasquez", 33, Job.Interpreter),
				new Person("August", "Rubio", 21, Job.Developer),
				new Person("Rocky", "Mcgee", 57, Job.Barber),
				new Person("Emerson", "Rollins", 42, Job.Choreographer),
				new Person("Everett", "Parks", 39, Job.Sculptor),
				new Person("Amelia", "Moody", 24, Job.Waiter)
				{ Dogs = new List<Dog>() {dogs[16], dogs[18] } },
				new Person("Emilie", "Horn", 16, Job.Waiter),
				new Person("Leroy", "Baker", 44, Job.Interpreter),
				new Person("Nathen", "Higgins", 60, Job.Archivist)
				{ Dogs = new List<Dog>(){dogs[6], dogs[0] } },
				new Person("Erin", "Rocha", 37, Job.Developer)
				{ Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
				new Person("Freddy", "Gordon", 26, Job.Sculptor)
				{ Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
				new Person("Valeria", "Reynolds", 26, Job.Dentist),
				new Person("Cristofer", "Stanley", 28, Job.Dentist)
				{ Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15]}}
			};


			Console.WriteLine("People whos name starts with R orderd by age descening");
			var peopleNamedWithR = people.Where(name => name.FirstName.StartsWith('R')).OrderByDescending(person => person.Age).ToList();
			foreach(var person in peopleNamedWithR)
			{
				Console.WriteLine(person.FirstName + person.Age);
			};

			Console.WriteLine("========================================================================================");

			Console.WriteLine("Brown dogs older than 3");
			var brownDogs = dogs.Where(dog => dog.Color.ToLower() == "brown" && dog.Age > 3).OrderBy(dog => dog.Age);
			foreach (var dog in brownDogs)
			{
				Console.WriteLine(dog.Name + dog.Age + dog.Color);
			};

			Console.WriteLine("========================================================================================");



			Console.WriteLine("People wiht more than 2 dogs ordered by names descending");
			var peopleWithMoreDogs = people.Where(person => person.Dogs.Count > 2)
											.Where(person => person.Dogs.OrderByDescending(dog => dog.Name).ToList().Count != 0).ToList();
			foreach (var person in peopleWithMoreDogs)
			{
				Console.WriteLine(person.FirstName);
			}
			Console.WriteLine("========================================================================================");


			Console.WriteLine("Freddy's dogs older than 1");
			var freddysDogs = people.FirstOrDefault(person => person.FirstName == "Freddy")
									.Dogs
									.Where(dog => dog.Age > 1).ToList();
			foreach(var dog in freddysDogs)
			{
				Console.WriteLine(dog.Name + dog.Age);
			}

			Console.WriteLine("========================================================================================");


			Console.WriteLine("Nathen's fisrt dog");
			var nathensFisrtDog = people.FirstOrDefault(person => person.FirstName == "Nathen")
										.Dogs.First();
			Console.WriteLine(nathensFisrtDog.Name);

			Console.WriteLine("========================================================================================");


			Console.WriteLine("Names of Cristofer, Amelia, Erin and Freddy's white dogs ordered by descending");

			var whiteDogs = people.FindAll(people => people.FirstName == "Cristofer" && people.FirstName == "Amelia"
										  && people.FirstName == "Freddy" && people.FirstName == "Erin")
								  //.SelectMany(people => people.Dogs)
								  //.ToList()
								  //.Where(dog => dog.Color == "White")
								  //.OrderByDescending(dog => dog.Name)
								  .ToList();

			var listOfnames = new List<string>() { "Cristofer", "Freddy", "Erin", "Amelia" };

			var dogNames = people
						  .Where(person => listOfnames.Contains(person.FirstName))
						  .SelectMany(x => x.Dogs)
						  .Where(x => x.Color == "White")
						  .Select(x => x.Name)
						  .ToList();


			foreach (var name in dogNames)
			{
				Console.WriteLine(name);
			}

			Console.ReadLine();
        }
    }
}
