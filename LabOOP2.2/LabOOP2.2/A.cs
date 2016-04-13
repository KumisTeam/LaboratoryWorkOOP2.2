using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP2._2
{
    class A
    {
         int x;
        public A (int _x)
        {

        }
        public  void Method()
        {
            Console.WriteLine('q');
        }
    }

    class B:A
    {

        public B(int _z):base(_z)
        {

        }

        public new void Method()
        {
            Console.WriteLine('s');
        }
    }
}
