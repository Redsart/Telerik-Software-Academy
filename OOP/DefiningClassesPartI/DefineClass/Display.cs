using System;

namespace DefineClass
{
    public class Display
    {
        private double diagonal;
        private int numberOfColours;

        public double Diagonal
        {
            get
            {
                return this.diagonal;
            }
            private set
            {
                if (value==0 || value>10)
                {
                    throw new ArgumentOutOfRangeException("The diagonal of display should be 0< >10");
                }
                else
                {
                    this.diagonal = value;
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

        //Empty constructor setting default values for screen diagonal and number of colours
        public Display() : this(4.0,256) { }

        //Constructor with 1 parameter size and default value for number of colours
        public Display(double size) : this(size, 256) { }

        //Full constructor taking parameters for size and number of colours
        public Display(double size, int colours)
        {
            this.Diagonal = size;
            this.NumberOfColours = colours;
        }

        public override string ToString()
        {
            return String.Format("The diagonal of display is {0}, the number of colours is {1}.",this.diagonal,this.numberOfColours);
        }
    }
}
