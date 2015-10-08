using System;

namespace School
{
    public class Disciplines : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length<2)
                {
                    throw new ArgumentException("Discipline name must be >2 symbols.");
                }
                this.name = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Lectures must be more than 0.");
                }
                this.numberOfLectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Exercises must be more than 0.");
                }
                this.numberOfLectures = value;
            }
        }

        public Disciplines(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
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
