using System;

namespace DefineClass
{
    public class Battery
    {
        private double hoursIdle;
        private double hoursTalk;
        private string model;
        private BatteryType type;

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
                if (value==0 || value>50)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be between 0-10!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            private set
        {
            this.type = value;
        }
        }
        //empty constructor setting "Standart" values for hours idle and hours talk
        public Battery() : this("Standart",100.0,10.0,BatteryType.LiIon) { }

        // Constructor taking 1 parameter for the model seting default setings for hours idle and hours talk
        public Battery(string model):this(model,100.0,10.0, BatteryType.LiIon)
        {
        }

        public Battery(string model, double idle, double talk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.Type = type;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, hours idle: {1}, hours talk: {2}, type: {3}",this.model,this.hoursIdle,this.hoursTalk,this.type); 
        }

    }
}
