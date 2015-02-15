//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//using System;
using System;
class Employee
{
    static void Main()
    {
        string firstName = "Andrei";
        string lastName = "Vasilev";
        byte age = 32;
        char gender = 'm';
        long idNumber = 8306112507;
        int UniqueEmployeeNumber = 27560327;
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Gender: "+ gender);
        Console.WriteLine("Personal ID Number: " + idNumber);
        Console.WriteLine("Unique Empolyee Number: " + UniqueEmployeeNumber);
    }
}

