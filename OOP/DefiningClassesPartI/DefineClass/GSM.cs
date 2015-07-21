using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClass
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private string owner;
        private Battery battery;
        private Display display;
        private double price;

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

        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}"+
                                "Manufacturer: {1}"+
                                "Owner: {2}"+
                                "Price: {3}"+
                                "Battery: {4}"+
                                "Display: {5}"
                                ,this.Model,this.Manufacturer,this.Owner,this.Price,this.Battery,this.Display);
        } 
    }
}
