//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All 
//animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name 
//and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHieararchy
{
    class AnimalHierarchyMain
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Djoni", 3, "Huskey", Gender.Male),
                new Dog("Lila", 5, "Beagle", Gender.Female),
                new Dog("Rex", 4, "German Shepherd Dog", Gender.Male),

                new Frog("Jabcho", 2, Gender.Male),
                new Frog("Jaban", 1, Gender.Male),
                new Frog("Jabka", 1, Gender.Female),

                new Kitten("Fani", 5, "American Bobtail"),
                new Tomcat("Tom", 3, "Balinesse"),
                new Cat("Mary", 1, "Bombay", Gender.Female)
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}",averageDogsAge);
            Console.WriteLine("Average age of the cats: {0}",averageCatsAge);
            Console.WriteLine("Average age of the frogs: {0}",averageFrogsAge);
        }
    }
}
