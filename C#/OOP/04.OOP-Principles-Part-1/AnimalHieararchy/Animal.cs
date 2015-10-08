using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHieararchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Age must be > 0");
                }
            }
        }

        public Gender Gender
        {
            get;
            protected set;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract void MakeSound();
    }
}
