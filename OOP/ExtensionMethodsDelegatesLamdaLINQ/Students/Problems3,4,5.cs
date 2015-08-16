//Problem 3. First before last

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

//Problem 4. Age range

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5. Order students

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arrayOfStudents=
            {
                new Student("Pesho","Ivanov",20),
                new Student("Andrei","Biserov",29),
                new Student("Krasimir","Petkanov",25),
                new Student("Georgi","Todorov",26),
                new Student("Filip","Kostov",21),
                new Student("Todor","Atanasov",25)
            };
            //Print all students
            Console.WriteLine("All students: \n");

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                Console.WriteLine("Student" + (i+1) + ": {0}",arrayOfStudents[i]);
            }

            var result = FirstNameBeforeLast(arrayOfStudents);
            Console.WriteLine("\nStudents whose first name is before last name alphabetically\n");
            
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nStudents whose age is between 18-24\n");
            var ageRange = FindPeopleOfCertainAge(arrayOfStudents,18,24);

            foreach (var student in ageRange)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nStudents sorted by first and then last name using lambda expressions:\n");
            var sortedStudents = arrayOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nStudents sorted by first and then last name using LINQ:\n");
            var sortedstudents1 =
                from student in arrayOfStudents
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var student in sortedstudents1)
            {
                Console.WriteLine(student);
            }
        }

        private static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            IEnumerable<Student> result =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return result;
        }

        private static IEnumerable<Student> FindPeopleOfCertainAge(Student[] students, int startAge, int endAge)
        {
            IEnumerable<Student> result =
                from student in students
                where student.Age >= startAge && endAge <= student.Age
                select student;

            return result;
        }
    }
}
