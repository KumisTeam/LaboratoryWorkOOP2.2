using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 5);
            Point C = new Point(5, 0);

            Threeangle T = new Threeangle(A, B, C);
            T.Show();
        }
    }
}
