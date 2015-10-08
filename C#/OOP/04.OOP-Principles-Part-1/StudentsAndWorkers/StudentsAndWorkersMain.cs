//Problem 2. Students and workers

//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new 
//field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() 
//that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class StudentsAndWorkersMain
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Ivanov", 4.5),
                new Student("Krasimir", "Shopov", 5.0),
                new Student("Georgi", "Evlogiev", 3.5),
                new Student("Filip", "Avramov", 3.0),
                new Student("Andrei", "Cholakov", 4.0),
                new Student("Ivo", "Peshev", 3.5),
                new Student("Petar", "Gerasimov", 4.0),
                new Student("Ivan", "Kirilov", 5.0),
                new Student("Todor", "Stoqnov", 5.5),
                new Student("Anatoli", "Bogdanov", 4.5)
            };

            var orderByGrade = students.OrderBy(x => x.Grade);
            foreach (var student in orderByGrade)
            {
                Console.WriteLine("Name: " + student.FirstName + " " + student.LastName + ", Grade: " + student.Grade);
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker("Asen", "Georgiev", 930.00, 8.5),
                new Worker("Filip", "Atanasov", 520.00, 7.5),
                new Worker("Georgi", "Filipov", 450.00, 7),
                new Worker("Velizar", "Toshev", 600.00, 8),
                new Worker("Toni", "Asenov", 550.00, 8),
                new Worker("Kiril", "Ivanov", 490.00, 7),
                new Worker("Ivan", "Kostov", 630.00, 8),
                new Worker("Trifon", "Mitev", 800.00, 9),
                new Worker("Genadi", "Popov", 540.00, 7.5),
                new Worker("Zdravko", "Andreev", 650.00, 8)
            };

            var orderBySalary = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in orderBySalary)
            {
                Console.WriteLine("Name: {0} {1}; Money per hour: {2:F2}"
                    ,worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("\nMerged and sorted by first and last name: ");
            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine("Person: {0} {1}",person.FirstName, person.LastName);
            }
        }
    }
}
