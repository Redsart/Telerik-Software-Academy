using System;
using System.IO;

namespace DefiningClassesPart2
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier)
        {
            using (StreamWriter sw=new StreamWriter(@"..\..\" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    sw.WriteLine(path.PathList[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path=new Path();

            using (StreamReader sr=new StreamReader(filePath))
            {
                while (sr.EndOfStream==false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}
