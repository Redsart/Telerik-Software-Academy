//Problem 4. Person class

//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to 
//display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class PersonClassMain
    {
        static void Main(string[] args)
        {
            Person ivo = new Person("Ivo");
            Person stefan = new Person("Stefan", 26);

            Console.WriteLine("Person with unspecified age:\n{0}",ivo);
            Console.WriteLine();
            Console.WriteLine("Person with specified age:\n{0}",stefan);
        }
    }
}
