using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2._2
{
    class Threeangle:Figure
    {
        public Threeangle(Point _A, Point _B, Point _C)
            :base(_A, _B, _C)
        {
            
        }

        public double Perim()
        {
            double side1 = base.Length(allPoints[0], allPoints[1]);
            double side2 = base.Length(allPoints[1], allPoints[2]);
            double side3 = base.Length(allPoints[2], allPoints[0]);

            return side1 + side2 + side3;
        }

        public double Square()
        {
            double PartPerim = Perim() / 2;

            double side1 = base.Length(allPoints[0], allPoints[1]);
            double side2 = base.Length(allPoints[1], allPoints[2]);
            double side3 = base.Length(allPoints[2], allPoints[0]);

            return Math.Sqrt(PartPerim 
                            * (PartPerim - side1)
                            * (PartPerim - side2)
                            * (PartPerim - side3));
        }

        public void Show()
        {
            Console.WriteLine("Points: ");
            foreach (var p in allPoints)
                Console.WriteLine(p.ToString());
            Console.WriteLine("Perim: ");
            Console.WriteLine(Perim());
            Console.WriteLine("Square: ");
            Console.WriteLine(Square());
        }

    }
}
