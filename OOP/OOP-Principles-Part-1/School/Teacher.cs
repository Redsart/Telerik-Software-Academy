using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher : People, IComment
    {
        private List<Disciplines> disciplines;

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            private set
            {
                if (value.Count<0)
                {
                    throw new ArgumentException("Disciplines must be > 0.");
                }
                this.disciplines = value;
            }
        }

        public string Comment
        {
            get;
            private set;
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

        public Disciplines Disciplines1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
