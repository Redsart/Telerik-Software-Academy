using System;

namespace AnimalHieararchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog {0} said: Cwag, cwag!",this.Name);
        }
    }
}
