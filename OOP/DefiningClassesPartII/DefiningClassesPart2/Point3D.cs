using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o; //problem 2

        public static Point3D O //problem 2
        {
            get
            {
                return o;
            }
        }

        static Point3D() // problem 2
        {
            o = new Point3D(0,0,0);
        }

        public double X //problem 1
        {
            get
            {
                return this.x;
            }
            private set
            {
                this.x = value;
            }
        }

        public double Y //problem 1
        {
            get
            {
                return this.y;
            }
            private set
            {
                this.y = value;
            }
        }

        public double Z //problem 1
        {
            get
            {
                return this.z;
            }
            private set
            {
                this.z = value;
            }
        }

        public Point3D(double xCoord, double yCoord, double zCoord) : this() //problem 1
        {
            this.X = xCoord;
            this.Y = yCoord;
            this.Z = zCoord;
        }

        public override string ToString() //problem 1
        {
            return String.Format("X= {0}, Y= {1}, Z= {2}",this.X,this.Y,this.Z);
        }

        public static Point3D Parse (string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz=new double[3];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) || input[i]== '-')
                {
                    while (i<input.Length && (char.IsDigit(input[i]) || input[i]=='-' || input[i]=='.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if(coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[index] = coord;
                    index++;
                    coordinates.Clear();
                }
            }
            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
