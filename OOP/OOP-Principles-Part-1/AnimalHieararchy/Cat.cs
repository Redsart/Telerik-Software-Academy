using System;

namespace AnimalHieararchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age) : base(name, age)
        {

        }

        public Cat(string name, int age, string breed) : base(name,age)
        {
            this.Breed = breed;
        }

        public Cat(string name, int age,string breed, Gender gender) : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get;
            private set;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Cat {0} sayd: Meow, meow!",this.Name);
        }
    }
}
