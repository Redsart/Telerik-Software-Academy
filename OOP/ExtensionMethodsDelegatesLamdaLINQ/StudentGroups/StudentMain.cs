using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGroups
{
    class StudentMain
    {
        public static Student SampleStudent1 = new Student("Georgi", "Petkov", "101012", "0888111222", "georgi@abv.bg",
            new List<int>
            {
            (int)PossibleMarks.Average,
            (int)PossibleMarks.Good,
            (int)PossibleMarks.Average,
            (int)PossibleMarks.VeryGood
            }, 2);

        public static Student SampleStudent2 = new Student("Filip", "Terziev", "114532", "0884212121", "filip@yahoo.com",
            new List<int>
            {
                (int)PossibleMarks.Good,
                (int)PossibleMarks.Excelent,
                (int)PossibleMarks.VeryGood,
                (int)PossibleMarks.Average
            },3);

        public static Student SampleStudent3 = new Student("Kiril", "Georgiev", "123232", "0898444555", "georgiev@gmail.com",
            new List<int>
            {
                (int)PossibleMarks.Good,
                (int)PossibleMarks.Average,
                (int)PossibleMarks.VeryGood,
                (int)PossibleMarks.Excelent
            }, 2);

        public static Student SampleStudent4 = new Student("Vladimir", "Angelov", "101544", "0888233223","angelov@abv.bg",
            new List<int>
            {
                (int)PossibleMarks.Poor,
                (int)PossibleMarks.Good,
                (int)PossibleMarks.Average,
                (int)PossibleMarks.Good
            }, 4);

        public static List<Student> sampleStudents = new List<Student> {SampleStudent1, SampleStudent2, SampleStudent3, SampleStudent4 };

        static void Main(string[] args)
        {
            
        }
    }
}
