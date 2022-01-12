using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgaram.polymorphisam
{
    internal class Animal //Base class
    {
        public string Name; //Animal field
        public virtual void Display() // Animal method
        {
            Console.WriteLine("Animal makes a sounds");
        }
    }
}
