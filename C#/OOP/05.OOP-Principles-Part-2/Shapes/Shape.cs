using System;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Width cant be negative or zero.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Height cant be negative or zero.");
                }
                this.height = value;
            }
        }

        public Shape(double width)
        {
            this.Width = width;
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
