using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClass
{
    public class Display
    {
        private double size;
        private int numberOfColours;

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value==0 || value>10)
                {
                    throw new ArgumentOutOfRangeException("The diagonal of display should be 0< >10");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            private set
            {
                if (value<256 || numberOfColours>int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The number of colours should be 256< > int.Maxvalue");
                }
                else
                {
                    this.numberOfColours = value;
                }
            }
        }

        public Display(double size, int colours)
        {
            this.Size = size;
            this.NumberOfColours = colours;
        }

        public override string ToString()
        {
            return String.Format("The diagonal of display is {0}, the number of colours is {1}.",size,numberOfColours);
        }
    }
}
