using System;

namespace AnimalHieararchy
{
    public class Dog : Animal, ISound
    {
        public string Breed
        {
            get;
            private set;
        }

        public Dog(string name, int age, string breed, Gender gender) : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog {0} said: Baw, baw!", this.Name);
        }
    }
}
