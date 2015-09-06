using System;

namespace School
{
    public class Student : People, IComment
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Class number must be > 0.");
                }
                this.classNumber = value;
            }
        }

        public SchoolClass SchoolClass
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }
    }
}
