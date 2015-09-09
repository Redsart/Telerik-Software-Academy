using System;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(double width) : base(width)
        {

        }

        public override double CalculateSurface()
        {
            return (this.Width*this.Width);
        }
    }
}
