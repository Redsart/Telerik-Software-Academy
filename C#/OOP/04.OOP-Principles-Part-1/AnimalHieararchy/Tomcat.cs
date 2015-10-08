using System;

namespace AnimalHieararchy
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age, string breed) : base(name, age, breed)
        {
            this.Gender = Gender.Male;
        }
    }
}
