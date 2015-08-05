using System;
using System.Collections.Generic;

namespace DefiningClassesPart2
{
    public class Path // problem 4
    {
        private List<Point3D> pathList;

        public List<Point3D> PathList
        {
            get
            {
                return this.pathList;
            }
            private set
            {
                this.pathList = value;
            }
        }

        public Path()
        {
            this.PathList=new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.pathList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pathList.Remove(point);
        }
    }
}
