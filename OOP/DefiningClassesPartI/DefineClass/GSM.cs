using System;
using System.Collections.Generic;

namespace DefineClass
{
    public class GSM
    {
        private static GSM iphone4s;
        private string model;
        private string manufacturer;
        private string owner;
        private Battery battery;
        private Display display;
        private double price;
        private List<Call> callHistory; //problem 9

        public static GSM Iphone4S
        {
            get
            {
                return iphone4s;
            }
            private set
            {
                iphone4s = value;
            }
        }

            static GSM()
        {
            Iphone4S=new GSM("Iphone", "4S", "New Owner",1999.99, new Battery("Bad", 5, 50, BatteryType.LiIon), new Display(), new List<Call>());
        }

        
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
                    throw new ArgumentOutOfRangeException("The model name should be more than 0 and less than 20 characters!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value.Length==0 || value.Length>20)
                {
                    throw new ArgumentOutOfRangeException("The maufacturer name should be more than 0 and less than 20 charachters!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (value.Length==0 || value.Length>30)
                {
                    throw new ArgumentOutOfRangeException("The owner name should be more than 0 and less than 30 charachters!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value==0 || value>2000)
                {
                    throw new ArgumentOutOfRangeException("The price should be in range 0-2000!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }
        //problem 9
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public GSM(string manufacturer, string model):this(model,manufacturer,"Georgi",1000.00,new Battery(),new Display(),new List<Call>())
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }
        //full constructor
        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display,List<Call>callHistory)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public override string ToString()
        {
            return String.Format("Model: {0}"+
                                "Manufacturer: {1}"+
                                "Owner: {2}"+
                                "Price: {3}"+
                                "Battery: {4}"+
                                "Display: {5}"
                                ,this.Model,this.Manufacturer,this.Owner,this.Price,this.Battery.ToString(),this.Display.ToString());
        }
        // problem 10
        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> ClearCallsHistory()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.callHistory);
        }
        //problem 11
        public decimal CalculateTotalPrice(decimal price)
        {
            int totalDuration = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                totalDuration = callHistory[i].Duration++;
            }
            decimal totalPrice = totalDuration * price;
            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return String.Format("Calls history: \n{0}",string.Join(Environment.NewLine,new List<Call>(this.callHistory)));
        }
    }
}
