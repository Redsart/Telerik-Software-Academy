using System;

namespace School
{
    public class People : SchoolMain
    {
        private string name;

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
                    throw new ArgumentNullException("Name cant be null or empty");
                }
                this.name = value;
            }
        }

        public People(string name)
        {
            this.Name = name;
        }
    }
}
