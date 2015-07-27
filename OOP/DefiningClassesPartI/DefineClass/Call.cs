using System;

namespace DefineClass
{
    public class Call
    {
        private DateTime date;
        private int duration;
        private string dialedPhone;

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            set
            {
                this.dialedPhone = value;
            }
        }

        public Call(DateTime callDateTime, string dialedPhoneNumber, int seconds)
        {
            this.Date = callDateTime;
            this.DialedPhone = dialedPhoneNumber;
            this.Duration = seconds;
        }

        public override string ToString()
        {
            return String.Format("Date and time: {0:G}; Duration: {1} seconds;\n Dialed phone number: {2}"
                ,this.date,this.duration,this.dialedPhone);
        }
    }
}
