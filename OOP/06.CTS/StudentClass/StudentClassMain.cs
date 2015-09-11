//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
//course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//Problem 2. ICloneable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type 
//Student.

//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social 
//security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class StudentClassMain
    {
        static void Main(string[] args)
        {
            Student test1 = new Student("Gosho", "Atanasov", "Ivanov", "123-45-678", "some address", "0888 112 223", "gosho@abv.bg",
                3, Specialties.Electronics, Universities.RU, Faculties.EEA);

            Student test2 = new Student("Filip", "Petrov", "Simeonov", "222-33-111", "another address", "0888 123 456",
                "petrov@yahoo.com", 2, Specialties.PublicLaw, Universities.NBU, Faculties.Law);

            Student test3 = new Student("Kristian", "Vasilev", "Petrov", "999-12-333", "awesome address", "0888 999 123",
                "vasilev@gmail.com", 4, Specialties.SoftwareEngineering, Universities.SU, Faculties.Informatics);

            bool compare1And2 = test1.Equals(test2);
            bool compare1And3 = test1.Equals(test3);
            bool compareWithOperator1And2 = test1 == test2;
            bool compareWithOperator1And3 = test1 == test3;
            int newHashCode = test1.GetHashCode();

            Console.WriteLine(test1);
            Console.WriteLine("Compare student 1 and student 2 with Equals: {0}\n"+
                "Compare student 1 and student 3 with Equals: {1}\n"+
                "Compare student 1 and student 2 with ==: {2}\n"+
                "Compare student 1 and student 3 with ==: {3}\n",
                compare1And2,compare1And3,compareWithOperator1And2,compareWithOperator1And3);
            Console.WriteLine("New HashCode of student 1: {0}",newHashCode);

            Student cloned = test1.Clone() as Student;

            Console.WriteLine("test1.CompareTo(test2): {0}",test1.CompareTo(test2));
            Console.WriteLine("test1.CompareTo(test3): {1}",test1.CompareTo(test3));
            Console.WriteLine("Cloned==test1? {0}", test1==cloned);
            test1 = test2;
            Console.WriteLine("Cloned==test1 after changing test? {0}",test1==cloned);
        }
    }
}
