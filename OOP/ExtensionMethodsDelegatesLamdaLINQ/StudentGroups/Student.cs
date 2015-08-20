using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGroups
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> mark;
        private int groupNumber;
        //private EmailValidator emailValidator = new EmailValidator();

        public Student(string fName, string lName, string fn, string tel, string email, List<int> allmarks, int group)
        {

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
                    throw new ArgumentNullException("First name of the student cant be null or empty.");
                }
                this.firstName=value;
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
                    throw new ArgumentNullException("Last name of the studen cant be null or empty.");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }
            private set
            {
                bool isNumber = true;
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        isNumber = false;
                    }
                }

                if (!isNumber)
                {
                    throw new ArgumentException("Faculty number must contains only digits");
                }
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || (value[0] != '+' && value[0] != '0'))
                {
                    throw new ArgumentException("Telephone cant be null or empty and must begin with + or 0.");
                }
                this.tel = value;
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

        public List<int> Mark
        {
            get
            {
                return this.mark;
            }

            private set
            {
                this.mark = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("The faculty number must be more than 0.");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("First name: {0} \nLast name: {1} \nFaculty number: {2} \nGroup number: {3}"+
                "\nMarks: {4} \nPhone: {5} \nEmail{6}",this.firstName, this.lastName, this.fn, this.groupNumber,
                String.Join(", ", this.mark), this.tel, this.email);
        }
    }
}
