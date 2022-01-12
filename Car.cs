using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgaram
{
    internal class Car:Vachile //derived class
    {
        public int Model; // car field
        public void Colour() //car method
        {
            Console.WriteLine("It is in Red colour");
        }
    }
}
