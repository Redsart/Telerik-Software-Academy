using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClass
{
    public class Battery
    {
        private double hoursIdle;
        private double hoursTalk;
        private string model;

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length==0 || value.Length>20)
                {
                    throw new ArgumentOutOfRangeException("The model must be longer than 0 and shorter than 20 symbols!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value==0 || value>528)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be between 0-500!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value==0 || value>10)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be between 0-10!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public Battery(string model, double idle, double talk)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, hours idle: {1}, hours talk: {2}",this.model,this.hoursIdle,this.HoursTalk);
        }
    }
}
