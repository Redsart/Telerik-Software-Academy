using System;

namespace DefiningClassesPart2
{
    public static class Distance // problem 3
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt((point1.X - point2.X)+(point1.Y - point2.Y)+(point1.Z - point2.Z));
            return distance;
        }
    }
}
