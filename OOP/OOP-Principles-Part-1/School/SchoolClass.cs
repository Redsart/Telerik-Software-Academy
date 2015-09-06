using System;
using System.Collections.Generic;

namespace School
{
    public class SchoolClass : IComment
    {
        private string identifier;

        public string Identrifier
        {
            get
            {
                return this.identifier;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Identifier cant be null or empty.");
                }
                this.identifier = value;
            }
        }

        public List<Student> Students
        {
            get;
            private set;
        }

        public List<Teacher> Teachers
        {
            get;
            private set;
        }

        public SchoolClass(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Identrifier = identifier;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Comment
        {
            get;
            private set;
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
