using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgaram.overloading
{
    internal class Overloading // using the same method by taking different parameters
    {
        public void Arthamatic(int a,int b) // method for a class of Overlaoding
        {
            Console.WriteLine("result=" + (a + b));// calculate sum of a amd b
        }
        public void Arthamatic(int a, int b,int c)
        {
            Console.WriteLine("result=" + (a + b + c));
        }
        public void Arthamatic(double a, int b)
        {
            Console.WriteLine("result=" +( a + b));
        }



    }
}
