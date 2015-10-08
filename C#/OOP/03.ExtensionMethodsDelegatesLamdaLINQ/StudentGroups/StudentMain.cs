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

        public static Student SampleStudent2 = new Student("Filip", "Terziev", "114532", "02100111", "filip@yahoo.com",
            new List<int>
            {
                (int)PossibleMarks.Good,
                (int)PossibleMarks.Excelent,
                (int)PossibleMarks.VeryGood,
                (int)PossibleMarks.Average
            }, 3);

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
                (int)PossibleMarks.Poor,
                (int)PossibleMarks.Average,
                (int)PossibleMarks.Good
            }, 4);

        public static List<Student> sampleStudents = new List<Student> {SampleStudent1, SampleStudent2, SampleStudent3, SampleStudent4 };

        static void Main(string[] args)
        {
            //select students from group 2
            var studentsFromGroup2 =
                from student in sampleStudents
                where student.GroupNumber == 2
                select student;
            // ordered students by first name
            var orderedStudentsFromGroup2 =
                from student in sampleStudents
                orderby student.FirstName
                select student;
            //print students in group 2 ordered by first name using LINQ
            Console.WriteLine("Students in group 2 ordered by first name (using LINQ):\n");
            foreach (var student in orderedStudentsFromGroup2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
            //using extension method
            Console.WriteLine("Students in group 2 ordered by first name (using extension method):\n");
            var orderedStudents2 = sampleStudents.Where(x=>x.GroupNumber==2).OrderBy(x=>x.FirstName);
            foreach (var student in orderedStudents2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            //problem 11 students with email in abv.bg

            var studentWithAbvEmail =
                from student in sampleStudents
                where student.Email.Contains("abv.bg")
                select student;
            Console.WriteLine("Students with email in abv.bg");
            foreach (var student in studentWithAbvEmail)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            // problem 12 students with phone in Sofia
            var studentWithPhoneInSofia =
                from student in sampleStudents
                where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
                select student;
            Console.WriteLine("Student with phone in Sofia");
            foreach (var student in studentWithPhoneInSofia)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            //problem 13 Extraxt students by marks
            var studentWithExcelentMark =
                from student in sampleStudents
                where student.Mark.Contains((int)PossibleMarks.Excelent)
                select new
                {
                    FullName=student.FirstName+" "+student.LastName,
                    MarkList=student.Mark
                };
            Console.WriteLine("Students that have atleast one excelent mark in new anonymous class that has properties FullName and Marks");
            foreach (var student in studentWithExcelentMark)
            {
                Console.WriteLine("FullName: {0}",student.FullName);
                Console.WriteLine("Marks: {0}",String.Join(", ",student.MarkList));
                Console.WriteLine();
            }

            //problem 14 Extract student with two marks "2"
            var studentWithTwoTwos = sampleStudents.Where(x => x.Mark.FindAll(y => y == 2).Count == 2).Select
                (x => new {FullName=x.FirstName+" "+x.LastName, MarkList=x.Mark });
            Console.WriteLine("Students that have exactly two poor marks in new anonymous class with properties FullName and Marks:\n");
            foreach (var student in studentWithTwoTwos)
            {
                Console.WriteLine("FullName: {0}",student.FullName);
                Console.WriteLine("Marks: {0}",String.Join(", ",student.MarkList));
                Console.WriteLine();
            }
            
            //problem 15 Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentsFrom2006 = sampleStudents.Where(x=>x.FN[4]=='0' && x.FN[5]=='6');
            var allMarksFrom2006 = new List<int>();
            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Mark);
            }
            Console.WriteLine("All marks of the students, enroled in 2006: \n{0}",String.Join(", ",allMarksFrom2006));
            Console.WriteLine();

            //problem 16 Groups
            Group group1 = new Group(1,"Mathematics");
            Group group2 = new Group(2,"Physics");
            Group group3 = new Group(3,"Literature");

            List<Group> groups = new List<Group> {group1, group2, group3};
            var studentsFromMathGroup =
                from somegroup in groups
                where somegroup.GroupNumber == 1
                join student in sampleStudents on somegroup.GroupNumber equals student.GroupNumber
                select new
                {
                    Name=student.FirstName+" "+student.LastName,
                    Department=somegroup.DepartmentName
                };
            Console.WriteLine("All students from mathematics department, extracted as new anonymous classes, containing properties Name and Department:");

            foreach (var student in studentsFromMathGroup)
            {
                Console.WriteLine(student);
            }
        } 
    }
}
