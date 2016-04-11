using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2._2
{
    class Figure
    {
        public readonly List<Point> allPoints;

        public Figure(Point A, Point B, Point C)
        {
            allPoints = new List<Point>();
            allPoints.Add(A);
            allPoints.Add(B);
            allPoints.Add(C);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            allPoints = new List<Point>();
            allPoints.Add(A);
            allPoints.Add(B);
            allPoints.Add(C);
            allPoints.Add(D);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            allPoints = new List<Point>();
            allPoints.Add(A);
            allPoints.Add(B);
            allPoints.Add(C);
            allPoints.Add(D);
            allPoints.Add(E);
        }

        protected double Length(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2)); ;
        }
    }
}
