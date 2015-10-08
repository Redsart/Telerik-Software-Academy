﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace StudentClass
{
    public class Student : IComparable, ICloneable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Specialties speciality;
        private Universities university;
        private Faculties faculty;

        public Student(string firstName, string middleName, string lastName, string ssn, string premanentAddress, string mobilePhone,
            string email, int course, Specialties speciality, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.speciality = speciality;
            this.university = university;
            this.faculty = faculty;
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or empty");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null ot empty");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            private set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }
        //if needed we can implement some validation for phone, address and email

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Course must be in range 1 - 5.");
                }
                this.course = value;
            }
        }

        private bool IsValidSSN(string ssn) // correct format XXX-XX-XXXX where X is digit
        {
            if (string.IsNullOrEmpty(ssn) || ssn.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < ssn.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    if (ssn[i] != '-')
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Char.IsDigit(ssn[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Universities University
        {
            get
            {
                return this.university;
            }
        }

        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }
        }

        public Specialties Speciality
        {
            get
            {
                return this.speciality;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var field in this.GetType().GetRuntimeFields())
            {
                result.AppendLine(field.Name + " "+ field.GetValue(this));
            }
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            var otherStudent = obj as Student;
            if (this.SSN==otherStudent.SSN)
            {
                return true;
            }
            return false;
        }

        public static bool operator==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.Email.GetHashCode() ^ this.LastName.GetHashCode();
        }

        private int GetSSNasNumber()
        {
            var numbersFromSSN = new StringBuilder();
            foreach (var symbol in this.SSN)
            {
                if (char.IsDigit(symbol))
                {
                    numbersFromSSN.Append(symbol);
                }
            }
            return int.Parse(numbersFromSSN.ToString());
        }

        public object Clone()
        {
            return new Student(
                this.FirstName.Clone() as string,
                this.MiddleName.Clone() as string,
                this.LastName.Clone() as string,
                this.SSN.Clone() as string,
                this.PermanentAddress.Clone() as string,
                this.MobilePhone.Clone() as string,
                this.Email.Clone() as string,
                this.Course,
                this.Speciality,
                this.University,
                this.Faculty);
        }

        public int CompareTo(object obj)
        {
            var otherStudent = obj as Student;
            string fullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (fullName.CompareTo(otherFullName) < 0)
            {
                return -1;
            }
            if (fullName.CompareTo(otherFullName) > 0)
            {
                return 1;
            }
            if (fullName.CompareTo(otherFullName) == 0)
            {
                if (this.GetSSNasNumber() < otherStudent.GetSSNasNumber())
                {
                    return -1;
                }
                if (this.GetSSNasNumber() > otherStudent.GetSSNasNumber())
                {
                    return 1;
                }
                if (this.GetSSNasNumber() == otherStudent.GetSSNasNumber())
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
